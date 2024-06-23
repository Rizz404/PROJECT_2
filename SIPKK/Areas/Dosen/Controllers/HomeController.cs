using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.Services;
using SIPKK.DataAccess.DosenServices.IServices;
using SIPKK.Models;
using System.Diagnostics;

namespace SIPKK.Areas.Dosen.Controllers
{
    [Area(nameof(Dosen))]
    [Authorize(Roles = nameof(Dosen))]
    public class HomeController : Controller
    {
        private readonly IProyekService _proyekService;
        private readonly IDosenService _dosenService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, IProyekService proyekService, IDosenService dosenService)
        {
            _userManager = userManager;
            _proyekService = proyekService;
            _dosenService = dosenService;
        }

        public async Task<IActionResult> Index()
        {
            var proyekList = await _proyekService.GetAllProyekAsync();
            return View(proyekList);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            var proyek = await _proyekService.GetProyekByIdAsync(id);

            if (proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
        }



    }
}
