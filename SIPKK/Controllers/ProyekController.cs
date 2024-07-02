using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;
using System.Linq.Expressions;
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

        public enum UserRole
        {
            Mahasiswa,
            Dosen,
            Admin
        }

        // nanti ini fix kalo udah jadi dan jadiin service aja
        protected async Task<UserRoleData> GetAssociatedRoleId(UserRole role)
        {
            var IdUser = _userManager.GetUserId(User);

            switch(role)
            {
                case UserRole.Mahasiswa:
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.IdUser == IdUser, includedProperties: [
                    m => m.Proyek,
                ]);
                if(mahasiswa != null)
                {
                    return new UserRoleData { Id = mahasiswa.Id, Proyek = mahasiswa.Proyek };
                }
                break;

                case UserRole.Dosen:
                var dosen = await _unitOfWork.Dosen.GetAsync(filter: d => d.IdUser == IdUser, includedProperties: [
                    d => d.Proyek
                ]);
                if(dosen != null)
                {
                    return new UserRoleData { Id = dosen.Id, Proyek = dosen.Proyek };
                }
                break;

                case UserRole.Admin:
                var admin = await _unitOfWork.Admin.GetAsync(filter: a => a.IdUser == IdUser);
                if(admin != null)
                {
                    return new UserRoleData { Id = admin.Id };
                }
                break;

                default:
                throw new ArgumentException("Role tidak dikenali", nameof(role));
            }

            throw new InvalidOperationException($"Tidak ditemukan entitas yang cocok untuk user dengan Id {IdUser} dan role {role}.");
        }

        public async Task<IActionResult> Index()
        {
            if(!User.Identity.IsAuthenticated)
            {
                var proyekListNotAuth = await _unitOfWork.Proyek.GetAllAsync();
                return View(proyekListNotAuth.Select(proyek => new ProyekVM() { Proyek = proyek }));
            }

            var currentMahasiswa = await GetAssociatedRoleId(UserRole.Mahasiswa);
            var proyekList = await _unitOfWork.Proyek.GetAllAsync(includedProperties:
            [
                p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan
            ]);

            if(proyekList == null || !proyekList.Any())
            {
                TempData["ErrorMessage"] = "Tidak ada proyek";
                return View();
            }

            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.Id == currentMahasiswa.Id, includedProperties: [
               m => m.Proyek,
            ]);
            var pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(filter: p => p.IdMahasiswa == currentMahasiswa.Id, includedProperties: [
               p => p.Proyek
            ]);

            var proyekVMTasks = proyekList.Select(proyek =>
            {
                string? proyekTerdaftarNameForCurrentMahasiswa = null;
                ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

                if(pendaftaran != null && pendaftaran.StatusPembayaran == false)
                {
                    status = ProyekVM.Status.PENDING;
                    proyekTerdaftarNameForCurrentMahasiswa = pendaftaran.Proyek.NamaProyek;
                }

                if(!string.IsNullOrEmpty(mahasiswa.IdProyek) && mahasiswa.Proyek != null)
                {
                    if(mahasiswa.IdProyek == proyek.Id)
                    {
                        status = ProyekVM.Status.TERDAFTAR;
                    }
                    else
                    {
                        status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                    }
                    proyekTerdaftarNameForCurrentMahasiswa = mahasiswa.Proyek.NamaProyek;
                }

                return Task.FromResult(new ProyekVM
                {
                    Proyek = proyek,
                    ProyekTerdaftarNameForCurrentMahasiswa = proyekTerdaftarNameForCurrentMahasiswa,
                    StatusMahasiswa = status
                });
                ;
            }).ToList();

            var proyekVMList = await Task.WhenAll(proyekVMTasks);


            return View(proyekVMList);
        }


        public async Task<IActionResult> Details(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            if(!User.Identity.IsAuthenticated)
            {
                var proyekNotAuth = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);
                return View(new ProyekVM() { Proyek = proyekNotAuth });
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

            var currentMahasiswa = await GetAssociatedRoleId(UserRole.Mahasiswa);

            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.Id == currentMahasiswa.Id, includedProperties: [
                m=> m.Proyek
            ]);
            var pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(filter: p => p.IdMahasiswa == currentMahasiswa.Id, includedProperties: [
                p=> p.Proyek
            ]);


            string? proyekTerdaftarNameForCurrentMahasiswa = null;
            ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

            if(pendaftaran != null && pendaftaran.StatusPembayaran == false)
            {
                status = ProyekVM.Status.PENDING;
                proyekTerdaftarNameForCurrentMahasiswa = pendaftaran.Proyek.NamaProyek;
            }

            if(!string.IsNullOrEmpty(mahasiswa.IdProyek) && mahasiswa.Proyek != null)
            {
                if(mahasiswa.IdProyek == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForCurrentMahasiswa = mahasiswa.Proyek.NamaProyek;
            }

            var proyekVM = new ProyekVM()
            {
                Proyek = proyek,
                ProyekTerdaftarNameForCurrentMahasiswa = proyekTerdaftarNameForCurrentMahasiswa,
                StatusMahasiswa = status
            };

            TempData["SuccessMessage"] = proyekTerdaftarNameForCurrentMahasiswa;
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

            var currentMahasiswa = await GetAssociatedRoleId(UserRole.Mahasiswa);

            using(var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.Id == currentMahasiswa.Id);

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
                var currentDosen = await GetAssociatedRoleId(UserRole.Dosen);
                var dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == currentDosen.Id);

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
