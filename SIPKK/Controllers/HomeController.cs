using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.Services;
using SIPKK.DataAccess.Services.IServices;
using SIPKK.Models;
using System.Diagnostics;

namespace SIPKK.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProyekService _proyekService;
        private readonly IDosenService _mahasiswaService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, IProyekService proyekService, IDosenService mahasiswaService)
        {
            _userManager = userManager;
            _proyekService = proyekService;
            _mahasiswaService = mahasiswaService;
        }

        public async Task<IActionResult> Index()
        {
            var proyekList = await _proyekService.GetAllProyekAsync();
            return View(proyekList);
        }

        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            var proyek = await _proyekService.GetProyekByIdAsync(id);

            if(proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
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

            var userId = _userManager.GetUserId(User);
            var (success, message) = await _mahasiswaService.DaftarProyekAsync(id, userId);

            if(!success)
            {
                TempData["ErrorMessage"] = message;
                return RedirectToAction(nameof(Details), new { id = id });
            }

            TempData["SuccessMessage"] = message;
            return RedirectToAction(nameof(Details), new { id = id });
        }


    }
}
