using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Visus.Cuid;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = nameof(Admin))]
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
            List<Proyek> proyekList = (await _unitOfWork.Proyek.GetAllAsync(includedProperties: [p => p.Mahasiswa])).ToList();
            return View(proyekList);
        }

        // GET: Proyek/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
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
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string proyekPath = Path.Combine(wwwRootPath, @"images\proyek");

                    if(!Directory.Exists(proyekPath))
                    {
                        Directory.CreateDirectory(proyekPath);
                    }

                    using(var fileStream = new FileStream(Path.Combine(proyekPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    proyekVM.Proyek.Verified = false;
                    proyekVM.Proyek.SudahSelesai = false;
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
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek? proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(proyek == null)
            {
                return NotFound();
            }

            ProyekVM proyekVM = new()
            {
                Proyek = proyek,
            };

            return View(proyekVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProyekVM proyekVM, IFormFile? file)
        {
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                var proyekFromDb = await _unitOfWork.Proyek.GetAsync(d => d.Id == proyekVM.Proyek.Id);

                if(proyekFromDb == null)
                {
                    return NotFound();
                }

                // Update the Proyek fields
                if(await TryUpdateModelAsync(proyekFromDb, "Proyek",
                    p => p.NamaProyek, p => p.Deskripsi, p => p.TanggalMulai, p => p.TanggalSelesai, p => p.Lokasi, p => p.Kuota, p => p.TipeProyek, p => p.Verified, p => p.SudahSelesai))
                {
                    // If a new file is uploaded, update the FotoProyek field
                    if(file != null)
                    {
                        string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        string proyekPath = Path.Combine(wwwRootPath, @"images\proyek");

                        if(!Directory.Exists(proyekPath))
                        {
                            Directory.CreateDirectory(proyekPath);
                        }

                        using(var fileStream = new FileStream(Path.Combine(proyekPath, filename), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        // Optionally, delete the old image file
                        if(!string.IsNullOrEmpty(proyekFromDb.FotoProyek))
                        {
                            var oldImagePath = Path.Combine(wwwRootPath, proyekFromDb.FotoProyek.TrimStart('\\'));
                            if(System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }

                        proyekFromDb.FotoProyek = @"\images\proyek\" + filename;
                    }

                    // Update Proyek entity
                    await _unitOfWork.Proyek.UpdateAsync(proyekFromDb);
                    await _unitOfWork.SaveAsync();

                    TempData["SuccessMessage"] = "Proyek updated successfully";
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(proyekVM);
        }


        // GET: Proyek/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
        }

        // POST: Proyek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Proyek? proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(proyek == null)
            {
                return NotFound();
            }
            await _unitOfWork.Proyek.DeleteAsync(proyek);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Proyek deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}