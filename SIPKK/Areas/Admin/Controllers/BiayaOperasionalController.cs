using Microsoft.AspNetCore.Authorization;
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
    [Route("Admin/[controller]/[action]")]
    public class BiayaOperasionalController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BiayaOperasionalController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: BiayaOperasional
        public async Task<IActionResult> Index()
        {
            List<BiayaOperasional> biayaOperasionalList = (await _unitOfWork.BiayaOperasional.FindAllAsync(
                include: q => q.Include(b => b.Proyek))).ToList();
            return View(biayaOperasionalList);
        }

        // GET: BiayaOperasional/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            BiayaOperasional biayaOperasional = await _unitOfWork.BiayaOperasional.FindAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: BiayaOperasional/Create
        public async Task<IActionResult> Create()
        {
            BiayaOperasionalVM biayaOperasionalVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(biayaOperasionalVM);
        }

        // POST: BiayaOperasional/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BiayaOperasionalVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.BiayaOperasional.CreateAsync(biayaOperasionalVM.BiayaOperasional);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "BiayaOperasional created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                biayaOperasionalVM.ProyekList = (await _unitOfWork.Proyek.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(biayaOperasionalVM);
            }
        }

        // GET: BiayaOperasional/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            BiayaOperasional? biayaOperasional = await _unitOfWork.BiayaOperasional.FindAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            BiayaOperasionalVM biayaOperasionalVM = new()
            {
                BiayaOperasional = biayaOperasional,
                ProyekList = (await _unitOfWork.Proyek.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(biayaOperasionalVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BiayaOperasionalVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.BiayaOperasional.UpdateAsync(biayaOperasionalVM.BiayaOperasional);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "BiayaOperasional updated successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                biayaOperasionalVM.ProyekList = (await _unitOfWork.Proyek.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(biayaOperasionalVM);
            }
        }

        // GET: BiayaOperasional/Upsert
        [HttpGet("{id?}")]
        public async Task<IActionResult> Upsert(string? id)
        {
            BiayaOperasionalVM biayaOperasionalVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
                BiayaOperasional = new BiayaOperasional(),
                IsUpdate = false,
            };

            if(!string.IsNullOrEmpty(id))
            {
                // update
                biayaOperasionalVM.BiayaOperasional = await _unitOfWork.BiayaOperasional.FindAsync(b => b.Id == id);
                if(biayaOperasionalVM.BiayaOperasional == null)
                {
                    return NotFound();
                }
                biayaOperasionalVM.IsUpdate = true;
            }
            return View(biayaOperasionalVM);
        }

        // POST: BiayaOperasional/Upsert
        [HttpPost("{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(string? id, BiayaOperasionalVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                if(string.IsNullOrEmpty(id))
                {
                    // Create
                    Debug.WriteLine("Performing create operation if is valid");
                    await _unitOfWork.BiayaOperasional.CreateAsync(biayaOperasionalVM.BiayaOperasional);
                    TempData["Success"] = "BiayaOperasional created successfully";
                }
                else
                {
                    // Update
                    Debug.WriteLine("Performing update operation if is valid");
                    await _unitOfWork.BiayaOperasional.UpdateAsync(biayaOperasionalVM.BiayaOperasional);
                    TempData["Success"] = "BiayaOperasional updated successfully";
                }
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                biayaOperasionalVM.ProyekList = (await _unitOfWork.Proyek.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(biayaOperasionalVM);
            }
        }

        // POST: BiayaOperasional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            BiayaOperasional? biayaOperasional = await _unitOfWork.BiayaOperasional.FindAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }
            await _unitOfWork.BiayaOperasional.DeleteAsync(biayaOperasional);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "BiayaOperasional deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}