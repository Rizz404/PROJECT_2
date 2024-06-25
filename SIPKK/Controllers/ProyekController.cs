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

namespace SIPKK.Controllers
{
    public class ProyekController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<ProyekController> _logger; // Tambahkan logger

        public ProyekController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, ILogger<ProyekController> logger)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _logger = logger;
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

                if(!string.IsNullOrEmpty(mahasiswa.IdProyek))
                {
                    TempData["ErrorMessage"] = "Sudah terdaftar di proyek";
                    return RedirectToAction(nameof(Details), new { id });
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
                        StatusPembayaran = false,
                    };

                    Debug.WriteLine(pendaftaran);
                    await _unitOfWork.Pendaftaran.CreateAsync(pendaftaran);
                    await _unitOfWork.SaveAsync();

                    scope.Complete(); // Commit transaction

                    TempData["SuccessMessage"] = "Pendaftaran berhasil silahkan melakukan pembayaran";
                    return RedirectToAction(nameof(Details), new { id });
                }
                catch(Exception ex)
                {
                    // Log the full exception including inner exception
                    _logger.LogError(ex, "Error occurred while registering mahasiswa to proyek.");

                    // Output the exception details to the debug console
                    Debug.WriteLine($"Exception: {ex.Message}");
                    if(ex.InnerException != null)
                    {
                        Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                        TempData["ErrorMessage"] = $"Inner Exception: {ex.InnerException.Message}";
                    }

                    return RedirectToAction(nameof(Details), new { id });
                }
            }
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DaftarForDosen(string id)
        {
            var proyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == id);

            if(string.IsNullOrEmpty(id) || proyek == null)
            {
                return NotFound();
            }

            try
            {
                var userId = GetUserId();

                var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId);

                dosen.IdProyek = proyek.Id;

                await _unitOfWork.Dosen.UpdateAsync(dosen);
                await _unitOfWork.SaveAsync();

                TempData["SuccessMessage"] = "Berhasil menjadi pembimbing proyek";
                return RedirectToAction(nameof(Details), new { id });
            }
            catch(Exception ex)
            {
                // Log the full exception including inner exception
                _logger.LogError(ex, "Error intinya");

                // Output the exception details to the debug console
                Debug.WriteLine($"Exception: {ex.Message}");
                if(ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    TempData["ErrorMessage"] = $"Inner Exception: {ex.InnerException.Message}";
                }

                return RedirectToAction(nameof(Details), new { id });
            }

        }
    }
}
