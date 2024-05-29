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
    public class ProyekController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProyekController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
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
        public async Task<IActionResult> Create(ProyekVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Proyek.CreateAsync(programStudiVM.Proyek);
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

            Proyek? biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            ProyekVM programStudiVM = new()
            {
                Proyek = biayaOperasional,
            };

            return View(programStudiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProyekVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Proyek.UpdateAsync(programStudiVM.Proyek);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Proyek updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Proyek/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek biayaOperasional = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
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

            if(biayaOperasional == null)
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