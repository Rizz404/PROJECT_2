using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using System.Diagnostics;

namespace SIPKK.Controllers
{
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
            var proyekList = await _unitOfWork.Proyek.GetAllAsync();
            return View(proyekList);
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
