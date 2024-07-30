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
    public class AngkatanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AngkatanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Angkatan
        public async Task<IActionResult> Index()
        {
            List<Angkatan> biayaOperasionalList = (await _unitOfWork.Angkatan.GetAllAsync()).ToList();
            return View(biayaOperasionalList);
        }

        // GET: Angkatan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Angkatan biayaOperasional = await _unitOfWork.Angkatan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: Angkatan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Angkatan/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AngkatanVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Angkatan.CreateAsync(programStudiVM.Angkatan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Angkatan created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Angkatan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Angkatan? biayaOperasional = await _unitOfWork.Angkatan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            AngkatanVM programStudiVM = new()
            {
                Angkatan = biayaOperasional,
            };

            return View(programStudiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AngkatanVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Angkatan.UpdateAsync(programStudiVM.Angkatan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Angkatan updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Angkatan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Angkatan biayaOperasional = await _unitOfWork.Angkatan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // POST: Angkatan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Angkatan? biayaOperasional = await _unitOfWork.Angkatan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }
            await _unitOfWork.Angkatan.DeleteAsync(biayaOperasional);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Angkatan deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}