using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;

public class ProfileController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public ProfileController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        string userId = _userManager.GetUserId(User);
        var user = await _userManager.FindByIdAsync(userId);
        var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId, m => m.ProgramStudi, m => m.Konsentrasi, m => m.Proyek);

        if(user == null || mahasiswa == null)
        {
            return NotFound();
        }

        ProfileVM profileVM = new ProfileVM()
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
        return View(profileVM);
    }

    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ProfileVM profileVM)
    {
        if(ModelState.IsValid)
        {
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
