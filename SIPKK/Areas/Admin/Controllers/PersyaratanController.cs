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
    public class PersyaratanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersyaratanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Persyaratan
        public async Task<IActionResult> Index()
        {
            List<Persyaratan> persyaratanList = (await _unitOfWork.Persyaratan.GetAllAsync(includedProperties:
            [
                p => p.Mahasiswa,
            ])).ToList();
            return View(persyaratanList);
        }

        // GET: Persyaratan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Persyaratan persyaratan = await _unitOfWork.Persyaratan.GetAsync(d => d.Id == id);

            if(persyaratan == null)
            {
                return NotFound();
            }

            return View(persyaratan);
        }

        // GET: Persyaratan/Create
        public async Task<IActionResult> Create()
        {
            PersyaratanVM persyaratanVM = new()
            {
                MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id.ToString(),
                }),
            };

            return View(persyaratanVM);
        }

        // POST: Persyaratan/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersyaratanVM persyaratanVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Persyaratan.CreateAsync(persyaratanVM.Persyaratan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Persyaratan created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                persyaratanVM.MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                });
                return View(persyaratanVM);
            }
        }

        // GET: Persyaratan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Persyaratan? persyaratan = await _unitOfWork.Persyaratan.GetAsync(d => d.Id == id);

            if(persyaratan == null)
            {
                return NotFound();
            }

            PersyaratanVM persyaratanVM = new()
            {
                Persyaratan = persyaratan,
                MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                }),
            };

            return View(persyaratanVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PersyaratanVM persyaratanVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Persyaratan.UpdateAsync(persyaratanVM.Persyaratan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Persyaratan updated successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                persyaratanVM.MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                });
                return View(persyaratanVM);
            }
        }

        // GET: Persyaratan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Persyaratan persyaratan = await _unitOfWork.Persyaratan.GetAsync(d => d.Id == id);

            if(persyaratan == null)
            {
                return NotFound();
            }

            return View(persyaratan);
        }

        // POST: Persyaratan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Persyaratan? persyaratan = await _unitOfWork.Persyaratan.GetAsync(d => d.Id == id);

            if(persyaratan == null)
            {
                return NotFound();
            }
            await _unitOfWork.Persyaratan.DeleteAsync(persyaratan);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Persyaratan deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}