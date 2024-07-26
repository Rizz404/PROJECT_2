using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;

namespace SIPKK.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var proyekList = await _unitOfWork.Proyek.GetAllAsync();
            return View(proyekList);
        }

        public async Task<IActionResult> NavbarData()
        {
            bool hasProyek = false;
            if(_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);

                if(user != null)
                {
                    var roles = await _userManager.GetRolesAsync(user);

                    if(roles.Contains("Mahasiswa"))
                    {
                        var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == user.Id);

                        if(mahasiswa.IdProyekKKP != null)
                        {
                            hasProyek = true;
                            return View(new HelperVM
                            {
                                HasProyek = hasProyek
                            });
                        }
                    }
                    else if(roles.Contains("Dosen"))
                    {
                        var dosen = await _unitOfWork.Dosen.GetAsync(m => m.IdUser == user.Id);

                        if(dosen.IdProyek != null)
                        {
                            hasProyek = true;
                            return View(new HelperVM
                            {
                                HasProyek = hasProyek
                            });
                        }
                    }
                }
            }

            return View(new HelperVM
            {
                HasProyek = hasProyek
            });
        }

        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            var proyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == id);

            if(proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
        }
    }
}
