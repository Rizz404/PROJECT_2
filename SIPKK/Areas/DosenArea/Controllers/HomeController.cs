using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.Services;

using SIPKK.Models;
using System.Diagnostics;

namespace SIPKK.Areas.DosenArea.Controllers
{
    [Area(nameof(DosenArea))]
    [Authorize(Roles = nameof(DosenArea))]
    public class HomeController : Controller
    {
      
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

      
        public HomeController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;

        }

        public async Task<IActionResult> Index()
        {
            List<Models.Proyek> proyekList = (await _unitOfWork.Proyek.GetAllAsync()).ToList();
            return View(proyekList);
          
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }
            Models.Proyek proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);
            

            if (proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
        }



    }
}
