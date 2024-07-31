using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;

namespace SIPKK.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FeedbackController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        protected string GetUserId()
        {
            return _userManager.GetUserId(User);
        }

        public async Task<IActionResult> Create(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan? laporan = await _unitOfWork.Laporan.FindAsync(filter: d => d.Id == id);

            if(laporan == null)
            {
                return NotFound();
            }

            LaporanVM laporanVM = new()
            {
                Laporan = laporan,
            };

            return View(laporanVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LaporanVM laporanVM)
        {
            if(ModelState.IsValid)
            {
                var laporan = await _unitOfWork.Laporan.FindAsync(filter: d => d.Id == laporanVM.Laporan.Id);
                if(laporan == null)
                {
                    return NotFound();
                }

                // Update only the Feedback field
                laporan.Feedback = laporanVM.Laporan.Feedback;

                // Save the changes
                await _unitOfWork.Laporan.UpdateAsync(laporan);
                await _unitOfWork.SaveAsync();

                TempData["SuccessMessage"] = "Feedback berhasil diperbarui";
                return Redirect("/MyProyek/Laporan/");
            }
            return View(laporanVM);
        }
    }
}
