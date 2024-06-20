using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;

public class DosenProfileController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public DosenProfileController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
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
        var dosen = await _unitOfWork.Dosen.GetAsync(m => m.Id == userId, m => m.Proyek);

        if(user == null || dosen == null)
        {
            return NotFound();
        }

       /* ProfileVM profileVM = new ProfileVM()
        {
            IdUser = user.Id, // Update here
            UserName = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            Id = mahasiswa.Id,
            NIM = mahasiswa.NIM,
            FirstName = mahasiswa.FirstName,
            LastName = mahasiswa.LastName,
            TanggalLahir = mahasiswa.TanggalLahir,
            Semester = mahasiswa.Semester,
            FotoProfil = mahasiswa.FotoProfil,
            ProgramStudi = mahasiswa.ProgramStudi.Nama,
            Konsentrasi = mahasiswa.Konsentrasi.Nama,
            Proyek = mahasiswa.Proyek != null ? mahasiswa.Proyek.NamaProyek : "Belum mendaftar",
        };
        */

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
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            if(file != null)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string mahasiswaPath = Path.Combine(wwwRootPath, @"images\mahasiswa");

                //if(string.IsNullOrEmpty(profileVM.FotoProfil))
                //{
                //    // hapus image old
                //    var oldImagePath = Path.Combine(wwwRootPath, profileVM.FotoProfil.TrimStart('\\'));

                //    if(System.IO.File.Exists(oldImagePath))
                //    {
                //        System.IO.File.Delete(oldImagePath);
                //    }
                //}

                using(var fileStream = new FileStream(Path.Combine(mahasiswaPath, filename), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                profileVM.FotoProfil = @"\images\mahasiswa\" + filename;
            }
            var user = await _userManager.FindByIdAsync(profileVM.IdUser);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == profileVM.IdUser);

            if(user == null || mahasiswa == null)
            {
                return NotFound();
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

            // Update Mahasiswa fields
            mahasiswa.FirstName = profileVM.FirstName;
            mahasiswa.LastName = profileVM.LastName;
            mahasiswa.TanggalLahir = profileVM.TanggalLahir;
            mahasiswa.FotoProfil = profileVM.FotoProfil;
            mahasiswa.Semester = profileVM.Semester;

            await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(profileVM);
    }
}
