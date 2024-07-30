using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            var userId = GetUserId();

            var dosen = await _unitOfWork.Dosen.GetAsync(filter: m => m.IdUser == userId, includedProperties: [
                d => d.Proyek,
            ]);

            if(dosen == null)
            {
                return NotFound();
            }

            var Feedback = new Models.Feedback()
            {
                IdDosen = dosen.Id,
                IdKelompok = dosen.Proyek.TipeProyek == Proyek.Tipe.KKN ? id : null,
                IdMahasiswa = dosen.Proyek.TipeProyek == Proyek.Tipe.KKP ? id : null,
            };

            var FeedbackVM = new FeedbackVM()
            {
                Feedback = Feedback
            };

            return View(FeedbackVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FeedbackVM feedbackVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Feedback.CreateAsync(feedbackVM.Feedback);
                await _unitOfWork.SaveAsync();

                var userId = GetUserId();
                var dosen = await _unitOfWork.Dosen.GetAsync(filter: m => m.IdUser == userId, includedProperties: [
                   d => d.Proyek,
                ]);

                TempData["SuccessMessage"] = "Berhasil membuat feedback";
                return Redirect($"/Proyek/Details/{dosen.IdProyek}");
            }
            return View(feedbackVM);
        }
    }
}
