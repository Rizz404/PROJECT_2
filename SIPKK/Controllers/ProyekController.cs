using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;

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
            var userRole = await GetUserRole();

            switch(userRole)
            {
                case UserRole.Mahasiswa:
                return await HandleMahasiswaView();

                case UserRole.Dosen:
                return await HandleDosenView();

                default:
                return await HandleUnauthenticatedView();
            }
        }

        private async Task<UserRole> GetUserRole()
        {
            var user = await _userManager.GetUserAsync(User);
            if(user != null)
            {
                if(await _userManager.IsInRoleAsync(user, "Mahasiswa"))
                    return UserRole.Mahasiswa;
                if(await _userManager.IsInRoleAsync(user, "Dosen"))
                    return UserRole.Dosen;
                return UserRole.Admin; // Atau role default lainnya
            }
            return UserRole.Admin;
        }

        private async Task<IActionResult> HandleMahasiswaView()
        {
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

            var proyekVMList = proyekList.Select(proyek =>
            {
                string? proyekTerdaftarNameForCurrentMahasiswa = null;
                ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

                if(pendaftaran != null && pendaftaran.StatusPembayaran == false)
                {
                    status = ProyekVM.Status.PENDING;
                    proyekTerdaftarNameForCurrentMahasiswa = pendaftaran.Proyek.NamaProyek;
                }

                if(!string.IsNullOrEmpty(mahasiswa.IdProyekKKP) && mahasiswa.Proyek != null)
                {
                    if(mahasiswa.IdProyekKKP == proyek.Id)
                    {
                        status = ProyekVM.Status.TERDAFTAR;
                    }
                    else
                    {
                        status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                    }
                    proyekTerdaftarNameForCurrentMahasiswa = mahasiswa.Proyek.NamaProyek;
                }

                return new ProyekVM
                {
                    Proyek = proyek,
                    ProyekTerdaftarNameForCurrentMahasiswa = proyekTerdaftarNameForCurrentMahasiswa,
                    StatusMahasiswa = status,
                    MahasiswaTerdaftar = proyek.Mahasiswa.Count()
                };
            }).ToList();

            return View(proyekVMList);
        }

        private async Task<IActionResult> HandleDosenView()
        {
            var currentDosen = await GetAssociatedRoleId(UserRole.Dosen);

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

            var dosen = await _unitOfWork.Dosen.GetAsync(filter: d => d.Id == currentDosen.Id, includedProperties: [
                d => d.Proyek,
            ]);

            var proyekVMList = proyekList.Select(proyek =>
            {
                string? proyekTerdaftarNameForCurrentDosen = null;
                ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

                if(!string.IsNullOrEmpty(dosen.IdProyek) && dosen.Proyek != null)
                {
                    if(dosen.IdProyek == proyek.Id)
                    {
                        status = ProyekVM.Status.TERDAFTAR;
                    }
                    else
                    {
                        status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                    }
                    proyekTerdaftarNameForCurrentDosen = dosen.Proyek.NamaProyek;
                }

                return new ProyekVM
                {
                    Proyek = proyek,
                    ProyekTerdaftarNameForCurrentMahasiswa = proyekTerdaftarNameForCurrentDosen,
                    StatusMahasiswa = status,
                    MahasiswaTerdaftar = proyek.Mahasiswa.Count()
                };
            }).ToList();

            return View(proyekVMList);
        }

        private async Task<IActionResult> HandleUnauthenticatedView()
        {
            var proyekListNotAuth = await _unitOfWork.Proyek.GetAllAsync();
            return View(proyekListNotAuth.Select(proyek => new ProyekVM() { Proyek = proyek }));
        }

        private async Task<IActionResult> HandleMahasiswaViewDetails(string id)
        {
            var proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id,
                p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan,
                p => p.Kelompok
            );

            if(proyek == null)
            {
                return NotFound();
            }

            var kelompok = await _unitOfWork.Kelompok.GetAllAsync(filter: k => k.IdProyek == id, includedProperties: [
                k=> k.Mahasiswa
            ]);

            var currentMahasiswa = await GetAssociatedRoleId(UserRole.Mahasiswa);

            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.Id == currentMahasiswa.Id, includedProperties: [
                m=> m.Proyek, m=> m.Kelompok
            ]);

            string? proyekTerdaftarNameForCurrentMahasiswa = null;
            ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

            if(!string.IsNullOrEmpty(mahasiswa.IdProyekKKP) && mahasiswa.Proyek != null)
            {
                if(mahasiswa.IdProyekKKP == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForCurrentMahasiswa = mahasiswa.Proyek.NamaProyek;
            }
            else if(!string.IsNullOrEmpty(mahasiswa.IdKelompok) && mahasiswa.Kelompok != null)
            {
                if(mahasiswa.Kelompok.IdProyek == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForCurrentMahasiswa = "hehe";
            }

            var proyekVM = new ProyekVM()
            {
                Proyek = proyek,
                ProyekTerdaftarNameForCurrentMahasiswa = proyekTerdaftarNameForCurrentMahasiswa,
                StatusMahasiswa = status,
                MahasiswaTerdaftar = proyek.Mahasiswa.Count(),
                KelompokList = (ICollection<Kelompok>)kelompok,
                RoleMahasiswa = mahasiswa.RoleMahasiswa
            };

            return View(proyekVM);
        }

        private async Task<IActionResult> HandleDosenViewDetails(string id)
        {
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

            var currentDosen = await GetAssociatedRoleId(UserRole.Dosen);

            var dosen = await _unitOfWork.Dosen.GetAsync(filter: m => m.Id == currentDosen.Id, includedProperties: [
                d=> d.Proyek
            ]);

            string? proyekTerdaftarNameForCurrentMahasiswa = null;
            ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

            if(!string.IsNullOrEmpty(dosen.IdProyek) && dosen.Proyek != null)
            {
                if(dosen.IdProyek == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForCurrentMahasiswa = dosen.Proyek.NamaProyek;
            }

            var proyekVM = new ProyekVM()
            {
                Proyek = proyek,
                ProyekTerdaftarNameForCurrentMahasiswa = proyekTerdaftarNameForCurrentMahasiswa,
                StatusMahasiswa = status,
                MahasiswaTerdaftar = proyek.Mahasiswa.Count()
            };

            return View(proyekVM);
        }

        private async Task<IActionResult> HandleUnauthenticatedViewDetails(string id)
        {
            var proyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == id);
            return View(new ProyekVM()
            {
                Proyek = proyek,
            });
        }

        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            var userRole = await GetUserRole();

            switch(userRole)
            {
                case UserRole.Mahasiswa:
                return await HandleMahasiswaViewDetails(id);

                case UserRole.Dosen:
                return await HandleDosenViewDetails(id);

                default:
                return await HandleUnauthenticatedViewDetails(id);
            }
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DaftarJadiPembimbing(string id)
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

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> JoinKelompok(string id)
        {
            try
            {
                var currentMahasiswa = await GetAssociatedRoleId(UserRole.Mahasiswa);
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.Id == currentMahasiswa.Id, includedProperties: [
                    m => m.Kelompok
                    ]);

                if(mahasiswa == null)
                {
                    TempData["ErrorMessage"] = "Mahasiswa tidak ditemukan.";
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                if(mahasiswa.RoleMahasiswa == Mahasiswa.Role.KETUA)
                {
                    TempData["ErrorMessage"] = "Ketua tidak bisa gabung kelompok lains";
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                mahasiswa.IdKelompok = id;

                await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                await _unitOfWork.SaveAsync();

                TempData["SuccessMessage"] = $"Berhasil menjadi anggota kelompok {mahasiswa.Kelompok?.NamaKelompok ?? "kelompok yang dipilih"}."; // Use null-coalescing operator to prevent null reference exception
                return Redirect(Request.Headers["Referer"].ToString());

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

                return Redirect(Request.Headers["Referer"].ToString());
            }
        }
    }
}