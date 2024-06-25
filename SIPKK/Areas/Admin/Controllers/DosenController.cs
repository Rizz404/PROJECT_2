using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using SIPKK.Ultilities;
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
    [Area("Admin")]
    [Authorize(Roles = nameof(Admin))]
    public class DosenController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public DosenController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Dosens
        public async Task<IActionResult> Index()
        {
            List<Dosen> dosenList = (await _unitOfWork.Dosen.GetAllAsync(includedProperties:
            [
                d => d.Proyek,
            ])).ToList();
            return View(dosenList);
        }

        // GET: Dosens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == id, d => d.Proyek);

            if(dosen == null)
            {
                return NotFound();
            }

            return View(dosen);
        }

        // GET: Dosens/Create
        public async Task<IActionResult> Create()
        {
            DosenVM dosenVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }).ToList(),
                Dosen = new Dosen()
            };

            return View(dosenVM);
        }

        // POST: Dosens/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DosenVM dosenVM)
        {
            string[] namaDosenArr = dosenVM.Dosen.NamaDosen.Split(" ");

            // Buat username, email, dan password
            string username = namaDosenArr.Length > 1 ? namaDosenArr[0] : dosenVM.Dosen.NamaDosen + new Cuid2().ToString();
            string email = $"{dosenVM.Dosen.NIDN}@global.ac.id";
            string password = "123456789"; // nanti ganti ke tanggal lahir aja

            if(ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = username, Email = email };
                var createNewUser = await _userManager.CreateAsync(user, password);

                if(createNewUser.Succeeded)
                {
                    var addRoleToUser = await _userManager.AddToRoleAsync(user, SD.Role_Dosen);

                    if(addRoleToUser.Succeeded)
                    {
                        Dosen dosen = new()
                        {
                            IdUser = user.Id,
                            NIDN = dosenVM.Dosen.NIDN,
                            NamaDosen = dosenVM.Dosen.NamaDosen,
                            IdProyek = dosenVM.Dosen.IdProyek,
                            TanggalLahir = dosenVM.Dosen.TanggalLahir,
                            FotoProfil = dosenVM.Dosen.FotoProfil,
                        };
                        await _unitOfWork.Dosen.CreateAsync(dosen);
                    }
                    foreach(var error in addRoleToUser.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                foreach(var error in createNewUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Dosen created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(dosenVM);
        }

        // GET: Dosens/Upsert
        public async Task<IActionResult> Upsert(string? id)
        {
            DosenVM dosenVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }).ToList(),
                Dosen = new Dosen()
            };

            if(!string.IsNullOrEmpty(dosenVM.Dosen.NamaDosen))
            {
                dosenVM.Dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == id, d => d.Proyek);
                if(dosenVM == null)
                {
                    return NotFound();
                }
            }
            return View(dosenVM);
        }

        // POST: Dosens/Upsert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(DosenVM dosenVM)
        {
            string[] namaDosenArr = dosenVM.Dosen.NamaDosen.Split(" ");

            // Buat username, email, dan password
            string username = namaDosenArr.Length > 1 ? namaDosenArr[0] : dosenVM.Dosen.NamaDosen + new Cuid2().ToString();
            string email = $"{dosenVM.Dosen.NIDN}@global.ac.id";
            string password = "123456789"; // nanti ganti ke tanggal lahir aja

            if(ModelState.IsValid)
            {
                if(string.IsNullOrEmpty(dosenVM.Dosen.Id) || string.IsNullOrEmpty(dosenVM.Dosen.NamaDosen))
                {
                    // sebenarnya bisa type explisit tapi gini lebih mudah dibaca
                    var user = new ApplicationUser { UserName = username, Email = email };
                    var createNewUser = await _userManager.CreateAsync(user, password);

                    if(createNewUser.Succeeded)
                    {
                        var addRoleToUser = await _userManager.AddToRoleAsync(user, SD.Role_Dosen);

                        if(addRoleToUser.Succeeded)
                        {
                            Dosen dosen = new()
                            {
                                IdUser = user.Id,
                                NIDN = dosenVM.Dosen.NIDN,
                                NamaDosen = dosenVM.Dosen.NamaDosen,
                                IdProyek = dosenVM.Dosen.IdProyek,
                                TanggalLahir = dosenVM.Dosen.TanggalLahir,
                                FotoProfil = dosenVM.Dosen.FotoProfil,
                            };
                            await _unitOfWork.Dosen.CreateAsync(dosen);
                            TempData["Success"] = "Dosen created successfully";
                        }
                        foreach(var error in addRoleToUser.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                    foreach(var error in createNewUser.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                else
                {
                    await _unitOfWork.Dosen.UpdateAsync(dosenVM.Dosen);
                    TempData["Success"] = "Dosen Updated successfully";
                }
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dosenVM);
        }

        // GET: Dosens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen dosenFromDb = await _unitOfWork.Dosen.GetAsync(d => d.Id == id, d => d.Proyek);

            if(dosenFromDb == null)
            {
                return NotFound();
            }

            DosenVM dosenVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }).ToList(),
                Dosen = dosenFromDb
            };

            return View(dosenVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DosenVM dosenVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Dosen.UpdateAsync(dosenVM.Dosen);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Dosen updated successfully";
                return RedirectToAction(nameof(Index));
            }
            dosenVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
            {
                Text = p.NamaProyek,
                Value = p.Id
            }).ToList();

            return View(dosenVM);
        }

        // GET: Dosens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Dosen? dosenFromDb = await _unitOfWork.Dosen.GetAsync(d => d.Id == id, d => d.Proyek);

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
            Dosen? dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == id, d => d.Proyek);

            if(dosen == null)
            {
                return NotFound();
            }

            ApplicationUser? user = await _userManager.FindByIdAsync(dosen.IdUser);

            using(var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _unitOfWork.Dosen.DeleteAsync(dosen);
                    await _unitOfWork.SaveAsync();

                    if(user != null)
                    {
                        var result = await _userManager.DeleteAsync(user);

                        if(!result.Succeeded)
                        {
                            TempData["Error"] = "Error deleting user";
                            return RedirectToAction(nameof(Index));
                        }
                    }

                    transaction.Complete();
                    TempData["Success"] = "Dosen deleted successfully";
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception)
                {
                    TempData["Error"] = "An error occurred while deleting Dosen";
                    return RedirectToAction(nameof(Index));
                }
            }
        }
    }
}