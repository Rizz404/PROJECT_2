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
    public class LaporanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LaporanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Laporan
        public async Task<IActionResult> Index()
        {
            List<Laporan> laporanList = (await _unitOfWork.Laporan.GetAllAsync()).ToList();
            return View(laporanList);
        }

        // GET: Laporan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan laporan = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(laporan == null)
            {
                return NotFound();
            }

            return View(laporan);
        }

        // GET: Laporan/Upsert
        [HttpGet("{id?}")]
        public async Task<IActionResult> Upsert(string? id)
        {
            LaporanVM laporanVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
                Laporan = new Laporan(), // Initialize BiayaOperasional
                IsUpdate = false
            };

            if(string.IsNullOrEmpty(id))
            {
                laporanVM.Laporan = await _unitOfWork.Laporan.GetAsync(b => b.Id == id);
                if(laporanVM.Laporan == null)
                {
                    return NotFound();
                }
                laporanVM.IsUpdate = true;
            }

            return View(laporanVM);
        }

        // POST: Laporan/Upsert
        [HttpPost("{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(string? id, LaporanVM laporanVM)
        {
            if(ModelState.IsValid)
            {
                if(string.IsNullOrEmpty(id))
                {
                    await _unitOfWork.Laporan.CreateAsync(laporanVM.Laporan);
                }
                else
                {
                    await _unitOfWork.Laporan.UpdateAsync(laporanVM.Laporan);
                }
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Laporan created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                laporanVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(laporanVM);
            }
        }

        // GET: Laporan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan laporan = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(laporan == null)
            {
                return NotFound();
            }

            return View(laporan);
        }

        // POST: Laporan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Laporan? laporan = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(laporan == null)
            {
                return NotFound();
            }
            await _unitOfWork.Laporan.DeleteAsync(laporan);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Laporan deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}