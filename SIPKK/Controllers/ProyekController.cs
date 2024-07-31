using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            switch (role)
            {
                case UserRole.Mahasiswa:
                    var mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(filter: m => m.IdUser == IdUser,
                        include: q => q.Include(m => m.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Proyek).Include(m => m.Persyaratan)
                    );
                    if (mahasiswa != null)
                    {
                        return new UserRoleData { Mahasiswa = mahasiswa, Id = mahasiswa.Id, Proyek = mahasiswa.Proyek, Persyaratan = mahasiswa.Persyaratan };
                    }
                    break;

                case UserRole.Dosen:
                    var dosen = await _unitOfWork.Dosen.FindAsync(filter: d => d.IdUser == IdUser,
                        include: q => q.Include(d => d.Proyek)
                        );
                    if (dosen != null)
                    {
                        return new UserRoleData { Dosen = dosen, Id = dosen.Id, Proyek = dosen.Proyek };
                    }
                    break;

                case UserRole.Admin:
                    var admin = await _unitOfWork.Admin.FindAsync(filter: a => a.IdUser == IdUser);
                    if (admin != null)
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

            switch (userRole)
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
            if (user != null)
            {
                if (await _userManager.IsInRoleAsync(user, "Mahasiswa"))
                    return UserRole.Mahasiswa;
                if (await _userManager.IsInRoleAsync(user, "Dosen"))
                    return UserRole.Dosen;
                return UserRole.Admin; // Atau role default lainnya
            }
            return UserRole.Admin;
        }

        private async Task<IActionResult> HandleMahasiswaView()
        {
            var currentUser = await GetAssociatedRoleId(UserRole.Mahasiswa);
            var mahasiswa = currentUser.Mahasiswa;

            var proyekList = await _unitOfWork.Proyek.FindAllAsync(
                 include: q => q.Include(m => m.Dosen).Include(p => p.Mahasiswa).Include(p => p.Kelompok)
            );

            if (proyekList == null || !proyekList.Any())
            {
                TempData["ErrorMessage"] = "Tidak ada proyek";
                return View();
            }

            if (mahasiswa == null)
            {
                TempData["ErrorMessage"] = "Data mahasiswa tidak ditemukan";
                return View();
            }

            var proyekVMList = proyekList.Select(proyek =>
            {
                int mahasiswaTerdaftar = proyek.TipeProyek == Proyek.Tipe.KKP ? proyek.Mahasiswa.Count() : proyek.Kelompok.Count();
                string? proyekTerdaftarNameForcurrentUser = null;
                ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

                if (mahasiswa != null && mahasiswa.Kelompok != null)
                {
                    if (mahasiswa.Kelompok.IdProyek == proyek.Id)
                    {
                        status = ProyekVM.Status.TERDAFTAR;
                    }
                    else
                    {
                        status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                    }
                    proyekTerdaftarNameForcurrentUser = mahasiswa.Kelompok.Proyek.NamaProyek;
                }

                if (mahasiswa != null && mahasiswa.Proyek != null)
                {
                    if (mahasiswa.IdProyekKKP == proyek.Id)
                    {
                        status = ProyekVM.Status.TERDAFTAR;
                    }
                    else
                    {
                        status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                    }
                    proyekTerdaftarNameForcurrentUser = mahasiswa.Proyek.NamaProyek;
                }

                return new ProyekVM
                {
                    Proyek = proyek,
                    ProyekTerdaftarNameForCurrentUser = proyekTerdaftarNameForcurrentUser,
                    StatusTerdaftar = status,
                    MahasiswaTerdaftar = mahasiswaTerdaftar
                };
            }).ToList();

            return View(proyekVMList);
        }

        private async Task<IActionResult> HandleDosenView()
        {
            var currentUser = await GetAssociatedRoleId(UserRole.Dosen);
            var dosen = currentUser.Dosen;

            var proyekList = await _unitOfWork.Proyek.FindAllAsync(
                 include: q => q.Include(m => m.Dosen).Include(p => p.Mahasiswa).Include(k => k.Kelompok)
            );

            if (proyekList == null || !proyekList.Any())
            {
                TempData["ErrorMessage"] = "Tidak ada proyek";
                return View();
            }

            var proyekVMList = proyekList.Select(proyek =>
            {
                int mahasiswaTerdaftar = proyek.TipeProyek == Proyek.Tipe.KKP ? proyek.Mahasiswa.Count() : proyek.Kelompok.Count();
                string? proyekTerdaftarNameForcurrentUser = null;
                ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

                if (dosen != null && dosen.Proyek != null)
                {
                    if (dosen.IdProyek == proyek.Id)
                    {
                        status = ProyekVM.Status.TERDAFTAR;
                    }
                    else
                    {
                        status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                    }
                    proyekTerdaftarNameForcurrentUser = dosen.Proyek.NamaProyek;
                }

                return new ProyekVM
                {
                    Proyek = proyek,
                    ProyekTerdaftarNameForCurrentUser = proyekTerdaftarNameForcurrentUser,
                    StatusTerdaftar = status,
                    MahasiswaTerdaftar = mahasiswaTerdaftar
                };
            }).ToList();

            return View(proyekVMList);
        }

        private async Task<IActionResult> HandleUnauthenticatedView()
        {
            var proyekListNotAuth = await _unitOfWork.Proyek.FindAllAsync();
            return View(proyekListNotAuth.Select(proyek => new ProyekVM() { Proyek = proyek }));
        }

        private async Task<IActionResult> HandleMahasiswaViewDetails(string id)
        {
            var currentUser = await GetAssociatedRoleId(UserRole.Mahasiswa);
            var mahasiswa = currentUser.Mahasiswa;

            var proyek = await _unitOfWork.Proyek.FindAsync(filter: p => p.Id == id,
                include: q => q.Include(m => m.Dosen).Include(p => p.Mahasiswa).Include(p => p.Kelompok).ThenInclude(k => k.Mahasiswa)
           );

            if (proyek == null)
            {
                return NotFound();
            }

            int mahasiswaTerdaftar = proyek.TipeProyek == Proyek.Tipe.KKP ? proyek.Mahasiswa.Count() : proyek.Kelompok.Count();
            string? proyekTerdaftarNameForcurrentUser = null;
            ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

            if (mahasiswa != null && mahasiswa.Kelompok != null)
            {
                if (mahasiswa.Kelompok.IdProyek == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForcurrentUser = mahasiswa.Kelompok.Proyek.NamaProyek;
            }

            if (mahasiswa != null && mahasiswa.Proyek != null)
            {
                if (mahasiswa.IdProyekKKP == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForcurrentUser = mahasiswa.Proyek.NamaProyek;
            }


            var proyekVM = new ProyekVM()
            {
                Proyek = proyek,
                Mahasiswa = mahasiswa,
                ProyekTerdaftarNameForCurrentUser = proyekTerdaftarNameForcurrentUser,
                StatusTerdaftar = status,
                MahasiswaTerdaftar = mahasiswaTerdaftar,
                RoleMahasiswa = mahasiswa.RoleMahasiswa
            };

            return View(proyekVM);
        }

        private async Task<IActionResult> HandleDosenViewDetails(string id)
        {
            var currentUser = await GetAssociatedRoleId(UserRole.Dosen);
            var dosen = currentUser.Dosen;

            var proyek = await _unitOfWork.Proyek.FindAsync(filter: p => p.Id == id,
                include: q => q.Include(p => p.Dosen).Include(p => p.Mahasiswa).Include(p => p.Kelompok).ThenInclude(k => k.Mahasiswa)
           );

            if (proyek == null)
            {
                return NotFound();
            }

            int mahasiswaTerdaftar = proyek.TipeProyek == Proyek.Tipe.KKP ? proyek.Mahasiswa.Count() : proyek.Kelompok.Count();
            string? proyekTerdaftarNameForcurrentUser = null;
            ProyekVM.Status status = ProyekVM.Status.TIDAK_TERDAFTAR;

            if (dosen != null && dosen.Proyek != null)
            {
                if (dosen.IdProyek == proyek.Id)
                {
                    status = ProyekVM.Status.TERDAFTAR;
                }
                else
                {
                    status = ProyekVM.Status.TERDAFTAR_PROYEK_LAIN;
                }
                proyekTerdaftarNameForcurrentUser = dosen.Proyek.NamaProyek;
            }


            var proyekVM = new ProyekVM()
            {
                Proyek = proyek,
                ProyekTerdaftarNameForCurrentUser = proyekTerdaftarNameForcurrentUser,
                StatusTerdaftar = status,
                MahasiswaTerdaftar = mahasiswaTerdaftar,
            };

            return View(proyekVM);
        }

        private async Task<IActionResult> HandleUnauthenticatedViewDetails(string id)
        {
            var proyek = await _unitOfWork.Proyek.FindAsync(p => p.Id == id);
            return View(new ProyekVM()
            {
                Proyek = proyek,
            });
        }

        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            var userRole = await GetUserRole();

            switch (userRole)
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
            var proyek = await _unitOfWork.Proyek.FindAsync(p => p.Id == id);

            if (string.IsNullOrEmpty(id) || proyek == null)
            {
                return NotFound();
            }

            try
            {
                var currentDosen = await GetAssociatedRoleId(UserRole.Dosen);
                var dosen = await _unitOfWork.Dosen.FindAsync(d => d.Id == currentDosen.Id);

                dosen.IdProyek = proyek.Id;

                await _unitOfWork.Dosen.UpdateAsync(dosen);
                await _unitOfWork.SaveAsync();

                TempData["SuccessMessage"] = "Berhasil menjadi pembimbing proyek";
                return RedirectToAction(nameof(Details), new { id });
            }
            catch (Exception ex)
            {
                // Log the full exception including inner exception
                _logger.LogError(ex, "Error intinya");

                // Output the exception details to the debug console
                Debug.WriteLine($"Exception: {ex.Message}");
                if (ex.InnerException != null)
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
                var currentUser = await GetAssociatedRoleId(UserRole.Mahasiswa);
                var mahasiswa = currentUser.Mahasiswa;

                if (mahasiswa == null)
                {
                    TempData["ErrorMessage"] = "Mahasiswa tidak ditemukan.";
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                if (mahasiswa.RoleMahasiswa == Mahasiswa.Role.KETUA)
                {
                    TempData["ErrorMessage"] = "Ketua tidak bisa gabung kelompok lain";
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                if (mahasiswa.RoleMahasiswa == null)
                {
                    TempData["ErrorMessage"] = "Silahkan ubah role ke anggota untuk join kelompok";
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                mahasiswa.IdKelompok = id;

                await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                await _unitOfWork.SaveAsync();

                TempData["SuccessMessage"] = $"Berhasil menjadi anggota kelompok {mahasiswa.Kelompok?.NamaKelompok ?? "kelompok yang dipilih"}."; // Use null-coalescing operator to prevent null reference exception
                return Redirect(Request.Headers["Referer"].ToString());

            }
            catch (Exception ex)
            {
                // Log the full exception including inner exception
                _logger.LogError(ex, "Error intinya");

                // Output the exception details to the debug console
                Debug.WriteLine($"Exception: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    TempData["ErrorMessage"] = $"Inner Exception: {ex.InnerException.Message}";
                }

                return Redirect(Request.Headers["Referer"].ToString());
            }
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DaftarKKP(string id)
        {
            try
            {
                var currentUser = await GetAssociatedRoleId(UserRole.Mahasiswa);
                var mahasiswa = currentUser.Mahasiswa;

                if (mahasiswa == null)
                {
                    TempData["ErrorMessage"] = "Mahasiswa tidak ditemukan.";
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                var errorMessages = new List<string>();
                if (mahasiswa.Persyaratan.KetPembayaran == false)
                {
                    errorMessages.Add("Kamu belum menyerahkan bukti pembayaran");
                }
                if (mahasiswa.Persyaratan.KetOrangTua == false)
                {
                    errorMessages.Add("Kamu belum menyerahkan bukti persetujuan orang tua");
                }
                if (mahasiswa.Persyaratan.KetKelakuanBaik == false)
                {
                    errorMessages.Add("Kamu belum menyerahkan bukti kelakuan baik");
                }
                if (mahasiswa.Persyaratan.KetSehat == false)
                {
                    errorMessages.Add("Kamu belum menyerahkan bukti keterangan sehat");
                }

                if (errorMessages.Any())
                {
                    TempData["ErrorMessage"] = errorMessages;
                    return Redirect(Request.Headers["Referer"].ToString());
                }

                mahasiswa.IdProyekKKP = id;

                await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                await _unitOfWork.SaveAsync();

                TempData["SuccessMessage"] = "Berhasil join kkp"; // Use null-coalescing operator to prevent null reference exception
                return Redirect(Request.Headers["Referer"].ToString());

            }
            catch (Exception ex)
            {
                // Log the full exception including inner exception
                _logger.LogError(ex, "Error intinya");

                // Output the exception details to the debug console
                Debug.WriteLine($"Exception: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    TempData["ErrorMessage"] = $"Inner Exception: {ex.InnerException.Message}";
                }

                return Redirect(Request.Headers["Referer"].ToString());
            }
        }
    }
}