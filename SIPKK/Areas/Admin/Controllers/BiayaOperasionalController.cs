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
            List<BiayaOperasional> biayaOperasionalList = (await _unitOfWork.BiayaOperasional.GetAllAsync(d => d.Proyek)).ToList();
            return View(biayaOperasionalList);
        }

        // GET: BiayaOperasional/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            BiayaOperasional biayaOperasional = await _unitOfWork.BiayaOperasional.GetAsync(d => d.Id == id);

            if(biayaOperasional == null)
            {
                return NotFound();
            }

            return View(biayaOperasional);
        }

        // GET: BiayaOperasional/Upsert
        public async Task<IActionResult> Upsert(string? id)
        {
            Debug.WriteLine($"GET Upsert method called with id: {id}");
            BiayaOperasionalVM biayaOperasionalVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
                BiayaOperasional = new BiayaOperasional()
            };

            if(!string.IsNullOrEmpty(id))
            {
                // update
                Debug.WriteLine("Performing update operation");
                biayaOperasionalVM.BiayaOperasional = await _unitOfWork.BiayaOperasional.GetAsync(b => b.Id == id);
                if(biayaOperasionalVM.BiayaOperasional == null)
                {
                    return NotFound();
                }
            }
            else
            {
                Debug.WriteLine("Performing create operation");
            }
            return View(biayaOperasionalVM);
        }

        // POST: BiayaOperasional/Upsert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(BiayaOperasionalVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                if(string.IsNullOrEmpty(biayaOperasionalVM.BiayaOperasional.Id))
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
                biayaOperasionalVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
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
            BiayaOperasional? biayaOperasional = await _unitOfWork.BiayaOperasional.GetAsync(d => d.Id == id);

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