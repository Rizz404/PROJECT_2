using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Visus.Cuid;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DosenController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DosenController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Dosens
        public async Task<IActionResult> Index()
        {
            List<Dosen> dosenList = (await _unitOfWork.Dosen.GetAllAsync()).ToList();
            return View(dosenList);
        }

        // GET: Dosens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == id);

            if(dosen == null)
            {
                return NotFound();
            }

            return View(dosen);
        }

        // GET: Dosens/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: Dosens/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Dosen obj)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Dosen.CreateAsync(obj);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Dosen created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        // GET: Dosens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen? dosenFromDb = await _unitOfWork.Dosen.GetAsync(d => d.Id == id);

            if(dosenFromDb == null)
            {
                return NotFound();
            }
            return View(dosenFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Dosen obj)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Dosen.UpdateAsync(obj);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Dosen updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Dosens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen? dosenFromDb = await _unitOfWork.Dosen.GetAsync(d => d.Id == id);

            if(dosenFromDb == null)
            {
                return NotFound();
            }
            return View(dosenFromDb);
        }

        // POST: Dosens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Dosen? dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == id);

            if(dosen == null)
            {
                return NotFound();
            }
            await _unitOfWork.Dosen.DeleteAsync(dosen);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Dosen deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}