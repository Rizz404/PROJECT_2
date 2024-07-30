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
    public class ProgramStudiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProgramStudiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: ProgramStudi
        public async Task<IActionResult> Index()
        {
            List<ProgramStudi> programStudiList = (await _unitOfWork.ProgramStudi.GetAllAsync()).ToList();
            return View(programStudiList);
        }

        // GET: ProgramStudi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            ProgramStudi programStudi = await _unitOfWork.ProgramStudi.GetAsync(d => d.Id == id);

            if(programStudi == null)
            {
                return NotFound();
            }

            return View(programStudi);
        }

        // GET: ProgramStudi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramStudi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProgramStudiVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.ProgramStudi.CreateAsync(programStudiVM.ProgramStudi);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "ProgramStudi created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: ProgramStudi/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            ProgramStudi? programStudi = await _unitOfWork.ProgramStudi.GetAsync(d => d.Id == id);

            if(programStudi == null)
            {
                return NotFound();
            }

            ProgramStudiVM programStudiVM = new()
            {
                ProgramStudi = programStudi,
            };

            return View(programStudiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProgramStudiVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.ProgramStudi.UpdateAsync(programStudiVM.ProgramStudi);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "ProgramStudi updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: ProgramStudi/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            ProgramStudi programStudi = await _unitOfWork.ProgramStudi.GetAsync(d => d.Id == id);

            if(programStudi == null)
            {
                return NotFound();
            }

            return View(programStudi);
        }

        // POST: ProgramStudi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            ProgramStudi? programStudi = await _unitOfWork.ProgramStudi.GetAsync(d => d.Id == id);

            if(programStudi == null)
            {
                return NotFound();
            }
            await _unitOfWork.ProgramStudi.DeleteAsync(programStudi);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "ProgramStudi deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}