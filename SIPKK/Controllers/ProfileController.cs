using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;

public class ProfileController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ProfileController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
        _webHostEnvironment = webHostEnvironment;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        string userId = _userManager.GetUserId(User);
        var user = await _userManager.FindByIdAsync(userId);

        if(user == null)
        {
            return NotFound();
        }

        var roles = await _userManager.GetRolesAsync(user);

        ProfileVM profileVM = new ProfileVM()
        {
            IdUser = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber
        };

        if(roles.Contains("Mahasiswa"))
        {
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == user.Id, m => m.ProgramStudi, m => m.Konsentrasi, m => m.Angkatan, m => m.Kelas, m => m.Kelompok, m => m.Proyek);
            if(mahasiswa != null)
            {
                profileVM.Id = mahasiswa.Id;
                profileVM.NIM = mahasiswa.NIM;
                profileVM.FirstName = mahasiswa.FirstName;
                profileVM.LastName = mahasiswa.LastName;
                profileVM.TanggalLahir = mahasiswa.TanggalLahir;
                profileVM.Semester = mahasiswa.Semester;
                profileVM.FotoProfil = mahasiswa.FotoProfil;
                profileVM.ProgramStudi = mahasiswa.ProgramStudi.Nama;
                profileVM.Konsentrasi = mahasiswa.Konsentrasi.Nama;
                profileVM.Angkatan = mahasiswa.Angkatan.Tahun;
                profileVM.Kelas = mahasiswa.Kelas.Nama;
                profileVM.Kelompok = mahasiswa.Kelompok?.NamaKelompok;
                profileVM.ProyekKKP = mahasiswa.Proyek?.NamaProyek;
                profileVM.RoleMahasiswa = mahasiswa.RoleMahasiswa;
            }
        }
        else if(roles.Contains("Dosen"))
        {
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == user.Id, d => d.Proyek);
            if(dosen != null)
            {
                profileVM.Id = dosen.Id;
                profileVM.NIDN = dosen.NIDN;
                profileVM.NamaDosen = dosen.NamaDosen;
                profileVM.TanggalLahir = dosen.TanggalLahir;
                profileVM.FotoProfil = dosen.FotoProfil;
                profileVM.Proyek = dosen.Proyek?.NamaProyek ?? "Belum ada proyek";
            }
        }
        else
        {
            return NotFound("User role tidak ditemukan atau tidak valid.");
        }

        return View(profileVM);
    }

    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ProfileVM profileVM, IFormFile? file)
    {
        // parameter file itu sesuaikan sama name file input ya
        if(ModelState.IsValid)
        {
            var user = await _userManager.FindByIdAsync(profileVM.IdUser);
            if(user == null)
            {
                return NotFound();
            }

            if(file != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string userPath = Path.Combine(wwwRootPath, @"images\users");

                if(!Directory.Exists(userPath))
                {
                    Directory.CreateDirectory(userPath);
                }

                if(!string.IsNullOrEmpty(profileVM.FotoProfil))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, profileVM.FotoProfil.TrimStart('\\'));
                    if(System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                using(var fileStream = new FileStream(Path.Combine(userPath, filename), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                profileVM.FotoProfil = @"\images\users\" + filename;
            }

            // Update ApplicationUser fields
            user.UserName = profileVM.UserName;
            user.Email = profileVM.Email;
            user.PhoneNumber = profileVM.PhoneNumber;

            var userUpdateResult = await _userManager.UpdateAsync(user);
            if(!userUpdateResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Gagal memperbarui pengguna");
                return View(profileVM);
            }

            var roles = await _userManager.GetRolesAsync(user);
            if(roles.Contains("Mahasiswa"))
            {
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == profileVM.IdUser);
                if(mahasiswa != null)
                {
                    mahasiswa.FirstName = profileVM.FirstName;
                    mahasiswa.LastName = profileVM.LastName;
                    mahasiswa.TanggalLahir = profileVM.TanggalLahir;
                    mahasiswa.FotoProfil = profileVM.FotoProfil;
                    mahasiswa.RoleMahasiswa = profileVM.RoleMahasiswa;
                    await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                }
            }
            else if(roles.Contains("Dosen"))
            {
                var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == profileVM.IdUser);
                if(dosen != null)
                {
                    dosen.NamaDosen = profileVM.NamaDosen;
                    dosen.TanggalLahir = profileVM.TanggalLahir;
                    dosen.FotoProfil = profileVM.FotoProfil;
                    await _unitOfWork.Dosen.UpdateAsync(dosen);
                }
            }

            await _unitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(profileVM);
    }
}
