using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.Services;
using SIPKK.DataAccess.Services.IServices;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;
using System.Transactions;

namespace SIPKK.Areas.DosenArea.Controllers
{
    [Area(nameof(DosenArea))]
    [Authorize(Roles = nameof(DosenArea))]

    public class ProyekController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProyekController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        protected string GetUserId()
        {
            return _userManager.GetUserId(User);
        }

        public async Task<IActionResult> Index()
        {
            var proyekList = (await _unitOfWork.Proyek.GetAllAsync(
                p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan))
                .ToList();

            var proyekVMList = proyekList.Select(proyek => new ProyekVM
            {
                Proyek = proyek,
                IsMahasiswaTerdaftar = proyek.Mahasiswa.Any(m => m.IdUser == GetUserId())
            }).ToList();

            return View(proyekVMList);
        }

        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            var proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id,
                p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan
            );

            if(proyek == null)
            {
                return NotFound();
            }

            var userId = GetUserId();
            var isMahasiswaTerdaftar = proyek.Mahasiswa.Any(m => m.IdUser == userId);

            var proyekVM = new ProyekVM()
            {
                Proyek = proyek,
                IsMahasiswaTerdaftar = isMahasiswaTerdaftar
            };

            return View(proyekVM);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Daftar(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var userId = GetUserId();

            using(var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

                if(mahasiswa == null)
                {
                    return NotFound();
                }

                var proyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == id);

                if(proyek == null)
                {
                    return NotFound();
                }

                if(proyek.Kuota <= 0)
                {
                    TempData["ErrorMessage"] = "Kuota proyek sudah penuh";
                    return RedirectToAction(nameof(Details), new { id });
                }

                var persyaratan = await _unitOfWork.Persyaratan.GetAsync(p => p.IdMahasiswa == mahasiswa.Id);
                if(persyaratan == null)
                {
                    persyaratan = new Persyaratan
                    {
                        IdMahasiswa = mahasiswa.Id,
                        KetKelakuanBaik = false,
                        KetOrangTua = false,
                        KetSehat = false,
                        KetPembayaran = false
                    };
                    await _unitOfWork.Persyaratan.CreateAsync(persyaratan);
                    await _unitOfWork.SaveAsync();
                }

                if(!persyaratan.KetPembayaran || !persyaratan.KetKelakuanBaik || !persyaratan.KetOrangTua || !persyaratan.KetSehat)
                {
                    TempData["ErrorMessage"] = "Syarat belum lengkap! Silahkan hubungi dosen terkait";
                    return RedirectToAction(nameof(Details), new { id });
                }

                mahasiswa.IdProyek = proyek.Id;
                proyek.Kuota -= 1;

                try
                {
                    await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                    await _unitOfWork.Proyek.UpdateAsync(proyek);

                    var pendaftaran = new Pendaftaran
                    {
                        IdMahasiswa = mahasiswa.Id,
                        IdProyek = proyek.Id,
                        TanggalPendaftaran = DateTime.UtcNow,
                        Status = "PENDING",
                    };

                    Debug.WriteLine(pendaftaran);
                    await _unitOfWork.Pendaftaran.CreateAsync(pendaftaran);
                    await _unitOfWork.SaveAsync();

                    scope.Complete(); // Commit transaction

                    TempData["SuccessMessage"] = "Pendaftaran berhasil";
                    return RedirectToAction(nameof(Details), new { id });
                }
                catch(Exception ex)
                {
                    TempData["ErrorMessage"] = "Terjadi kesalahan internal saat mendaftar mahasiswa ke proyek.";
                    return RedirectToAction(nameof(Details), new { id });
                }
            }
        }


    }
}
