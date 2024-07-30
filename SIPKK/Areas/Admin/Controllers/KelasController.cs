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
    public class KelasController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public KelasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Kelas
        public async Task<IActionResult> Index()
        {
            List<Kelas> biayaOperasionalList = (await _unitOfWork.Kelas.GetAllAsync()).ToList();
            return View(biayaOperasionalList);
        }

        // GET: Kelas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Kelas biayaOperasional = await _unitOfWork.Kelas.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: Kelas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kelas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KelasVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Kelas.CreateAsync(programStudiVM.Kelas);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Kelas created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Kelas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Kelas? biayaOperasional = await _unitOfWork.Kelas.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            KelasVM programStudiVM = new()
            {
                Kelas = biayaOperasional,
            };

            return View(programStudiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(KelasVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Kelas.UpdateAsync(programStudiVM.Kelas);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Kelas updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Kelas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Kelas biayaOperasional = await _unitOfWork.Kelas.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // POST: Kelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Kelas? biayaOperasional = await _unitOfWork.Kelas.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }
            await _unitOfWork.Kelas.DeleteAsync(biayaOperasional);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Kelas deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}