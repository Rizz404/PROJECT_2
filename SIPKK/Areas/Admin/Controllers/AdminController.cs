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
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            List<Models.Admin> biayaOperasionalList = (await _unitOfWork.Admin.GetAllAsync()).ToList();
            return View(biayaOperasionalList);
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Models.Admin biayaOperasional = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Admin.CreateAsync(programStudiVM.Admin);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Admin created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Models.Admin? biayaOperasional = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            AdminVM programStudiVM = new()
            {
                Admin = biayaOperasional,
            };

            return View(programStudiVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AdminVM programStudiVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Admin.UpdateAsync(programStudiVM.Admin);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Admin updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Models.Admin biayaOperasional = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Models.Admin? biayaOperasional = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }
            await _unitOfWork.Admin.DeleteAsync(biayaOperasional);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Admin deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}