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
            List<Laporan> biayaOperasionalList = (await _unitOfWork.Laporan.GetAllAsync()).ToList();
            return View(biayaOperasionalList);
        }

        // GET: Laporan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan biayaOperasional = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: Laporan/Create
        public async Task<IActionResult> Create()
        {
            LaporanVM biayaOperasionalVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(biayaOperasionalVM);
        }

        // POST: Laporan/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LaporanVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Laporan.CreateAsync(biayaOperasionalVM.Laporan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Laporan created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                biayaOperasionalVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(biayaOperasionalVM);
            }
        }

        // GET: Laporan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan? biayaOperasional = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            LaporanVM biayaOperasionalVM = new()
            {
                Laporan = biayaOperasional,
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(biayaOperasionalVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LaporanVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Laporan.UpdateAsync(biayaOperasionalVM.Laporan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Laporan updated successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                biayaOperasionalVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(biayaOperasionalVM);
            }
        }

        // GET: Laporan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan biayaOperasional = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // POST: Laporan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Laporan? biayaOperasional = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }
            await _unitOfWork.Laporan.DeleteAsync(biayaOperasional);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Laporan deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}