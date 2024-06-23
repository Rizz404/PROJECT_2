using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;

public class ProfileDosenController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ProfileDosenController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
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
        var dosen = await _unitOfWork.Dosen.GetAsync(m => m.Id == userId);

        if(user == null || dosen == null)
        {
            return NotFound();
        }

        ProfileDosenVM profileDosenVM = new ProfileDosenVM()
        {
            IdUser = user.Id, // Update here
            UserName = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            NIDN = dosen.NIDN,
            NamaDosen = dosen.NamaDosen,
           
            TanggalLahir = dosen.TanggalLahir,
            
            FotoProfil = dosen.FotoProfil,
           
        };
        return View(profileDosenVM);
    }

    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ProfileDosenVM profileDosenVM, IFormFile? file)
    {
        // parameter file itu sesuaikan sama name file input ya
        if(ModelState.IsValid)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            if(file != null)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string dosenPath = Path.Combine(wwwRootPath, @"images\dosen");

                //if(string.IsNullOrEmpty(profileVM.FotoProfil))
                //{
                //    // hapus image old
                //    var oldImagePath = Path.Combine(wwwRootPath, profileVM.FotoProfil.TrimStart('\\'));

                //    if(System.IO.File.Exists(oldImagePath))
                //    {
                //        System.IO.File.Delete(oldImagePath);
                //    }
                //}

                using(var fileStream = new FileStream(Path.Combine(dosenPath, filename), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                profileDosenVM.FotoProfil = @"\images\dosen\" + filename;
            }
            var user = await _userManager.FindByIdAsync(profileDosenVM.IdUser);
            var dosen = await _unitOfWork.Dosen.GetAsync(m => m.IdUser == profileDosenVM.IdUser);

            if(user == null || dosen == null)
            {
                return NotFound();
            }

            // Update ApplicationUser fields
            user.UserName = profileDosenVM.UserName;
            user.Email = profileDosenVM.Email;
            user.PhoneNumber = profileDosenVM.PhoneNumber;

            var userUpdateResult = await _userManager.UpdateAsync(user);
            if(!userUpdateResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Gagal memperbarui pengguna");
                return View(profileDosenVM);
            }
           

            // Update Mahasiswa fields
            dosen.NamaDosen = profileDosenVM.NamaDosen;
            dosen.TanggalLahir=profileDosenVM.TanggalLahir;
            dosen.FotoProfil =profileDosenVM.FotoProfil;
            
            await _unitOfWork.Dosen.UpdateAsync(dosen);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(profileDosenVM);
    }
}
