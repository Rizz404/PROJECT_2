using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.Services;
using SIPKK.DataAccess.Services.IServices;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;
using System.Transactions;

namespace SIPKK.Areas.DosenArea.Controllers
{
    [Area(nameof(DosenArea))]
    [Authorize(Roles = "Dosen")]

    public class ProyekController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProyekController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Proyek
        public async Task<IActionResult> Index()
        {
            List<Proyek> biayaOperasionalList = (await _unitOfWork.Proyek.GetAllAsync()).ToList();
            return View(biayaOperasionalList);
        }

        // GET: Proyek/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if (biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: Proyek/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proyek/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProyekVM proyekVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string mahasiswaPath = Path.Combine(wwwRootPath, @"images\proyek");

                    using (var fileStream = new FileStream(Path.Combine(mahasiswaPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    proyekVM.Proyek.FotoProyek = @"\images\proyek\" + filename;
                }
                await _unitOfWork.Proyek.CreateAsync(proyekVM.Proyek);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Proyek created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: Proyek/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek? biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if (biayaOperasional == null)
            {
                return NotFound();
            }

            ProyekVM proyekVM = new()
            {
                Proyek = biayaOperasional,
            };

            return View(proyekVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProyekVM proyekVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string mahasiswaPath = Path.Combine(wwwRootPath, @"images\proyek");

                    using (var fileStream = new FileStream(Path.Combine(mahasiswaPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    proyekVM.Proyek.FotoProyek = @"\images\proyek\" + filename;
                }

                await _unitOfWork.Proyek.UpdateAsync(proyekVM.Proyek);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Proyek updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Proyek/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if (biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // POST: Proyek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Proyek? biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if (biayaOperasional == null)
            {
                return NotFound();
            }
            await _unitOfWork.Proyek.DeleteAsync(biayaOperasional);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Proyek deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}