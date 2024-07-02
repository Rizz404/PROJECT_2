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
using System.Transactions;
using Visus.Cuid;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = nameof(Admin))]
    public class PendaftaranController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PendaftaranController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Pendaftaran
        public async Task<IActionResult> Index()
        {
            List<Pendaftaran> pendaftaranList = (await _unitOfWork.Pendaftaran.GetAllAsync(includedProperties: [p => p.Mahasiswa, p => p.Proyek])).ToList();
            return View(pendaftaranList);
        }

        // GET: Pendaftaran/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Pendaftaran pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == id);

            if(pendaftaran == null)
            {
                return NotFound();
            }

            return View(pendaftaran);
        }

        // GET: Pendaftaran/Create
        public async Task<IActionResult> Create()
        {
            PendaftaranVM pendaftaranVM = new()
            {
                MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                }),
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(pendaftaranVM);
        }

        // POST: Pendaftaran/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PendaftaranVM pendaftaranVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Pendaftaran.CreateAsync(pendaftaranVM.Pendaftaran);
                await _unitOfWork.SaveAsync();
                TempData["SuccessMessage"] = "Pendaftaran created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                pendaftaranVM.MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                });
                return View(pendaftaranVM);
            }
        }

        // GET: Pendaftaran/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Pendaftaran? pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == id);

            if(pendaftaran == null)
            {
                return NotFound();
            }

            PendaftaranVM pendaftaranVM = new()
            {
                Pendaftaran = pendaftaran,
            };

            return View(pendaftaranVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PendaftaranVM pendaftaranVM)
        {
            // karena ada upload image mungkin jadi error 
            if(ModelState.IsValid)
            {
                var pendaftaranFromDb = await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == pendaftaranVM.Pendaftaran.Id);
                if(pendaftaranFromDb == null)
                {
                    return NotFound();
                }

                using(var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        if(await TryUpdateModelAsync(pendaftaranFromDb, "Pendaftaran",
                        p => p.TanggalPendaftaran, p => p.StatusPembayaran))
                        {
                            if(!string.IsNullOrEmpty(pendaftaranFromDb.BuktiPembayaran) && pendaftaranFromDb.StatusPembayaran == true)
                            {
                                Mahasiswa mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.Id == pendaftaranFromDb.IdMahasiswa);
                                if(mahasiswa != null)
                                {
                                    mahasiswa.IdProyek = pendaftaranFromDb.IdProyek;
                                    await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                                }
                            }

                            await _unitOfWork.SaveAsync();
                            scope.Complete();
                            TempData["SuccessMessage"] = "Pendaftaran updated successfully";
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    catch(Exception ex)
                    {
                        // Output the exception details to the debug console
                        Debug.WriteLine($"Exception: {ex.Message}");
                        if(ex.InnerException != null)
                        {
                            Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                            TempData["ErrorMessage"] = $"Inner Exception: {ex.InnerException.Message}";
                        }

                        return RedirectToAction(nameof(Index));
                    }
                }
            }

            return View(pendaftaranVM);
        }

        // GET: Pendaftaran/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Pendaftaran pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == id);

            if(pendaftaran == null)
            {
                return NotFound();
            }

            return View(pendaftaran);
        }

        // POST: Pendaftaran/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Pendaftaran? pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == id);

            if(pendaftaran == null)
            {
                return NotFound();
            }
            await _unitOfWork.Pendaftaran.DeleteAsync(pendaftaran);
            await _unitOfWork.SaveAsync();
            TempData["SuccessMessage"] = "Pendaftaran deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}