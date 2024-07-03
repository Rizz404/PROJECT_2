using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
    [Area(nameof(Admin))]
    [Authorize(Roles = nameof(Admin))]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AdminController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            List<Models.Admin> adminList = (await _unitOfWork.Admin.GetAllAsync()).ToList();
            return View(adminList);
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Models.Admin admin = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminVM adminVM)
        {
            using(var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if(ModelState.IsValid)
                {
                    var existingUsername = await _unitOfWork.Admin.GetAsync(m => m.Username == adminVM.Admin.Username);
                    var existingEmail = await _unitOfWork.Admin.GetAsync(m => m.Email == adminVM.Admin.Email);

                    if(existingUsername != null || existingEmail != null)
                    {
                        TempData["ErrorMessage"] = "Admin telah ada";
                        return View(adminVM);
                    }

                    var user = new ApplicationUser
                    {
                        UserName = adminVM.Admin.Username,
                        Email = adminVM.Admin.Email,
                        EmailConfirmed = true
                    };

                    var createNewUser = await _userManager.CreateAsync(user, adminVM.Admin.Password);

                    if(createNewUser.Succeeded)
                    {
                        var addRoleToUser = await _userManager.AddToRoleAsync(user, SD.Role_Admin);

                        if(addRoleToUser.Succeeded)
                        {
                            Models.Admin admin = new()
                            {
                                IdUser = user.Id,
                                Username = adminVM.Admin.Username,
                                Email = adminVM.Admin.Email,
                                Password = adminVM.Admin.Password,
                            };

                            await _unitOfWork.Admin.CreateAsync(admin);
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
                    transaction.Complete();
                    TempData["SuccessMessage"] = "Admin created successfully";
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(adminVM);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Models.Admin? admin = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(admin == null)
            {
                return NotFound();
            }

            AdminVM adminVM = new()
            {
                Admin = admin,
            };

            return View(adminVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AdminVM adminVM)
        {
            using(var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if(ModelState.IsValid)
                {
                    var admin = await _unitOfWork.Admin.GetAsync(a => a.Id == adminVM.Admin.Id);

                    if(admin == null)
                    {
                        return NotFound();
                    }

                    var user = await _userManager.FindByIdAsync(admin.IdUser);

                    if(user == null)
                    {
                        return NotFound();
                    }

                    // Update user identity
                    user.UserName = adminVM.Admin.Username;
                    user.Email = adminVM.Admin.Email;
                    var updateUser = await _userManager.UpdateAsync(user);

                    if(updateUser.Succeeded)
                    {
                        // Update admin model
                        admin.Username = adminVM.Admin.Username;
                        admin.Email = adminVM.Admin.Email;
                        admin.Password = adminVM.Admin.Password;

                        await _unitOfWork.Admin.UpdateAsync(admin);
                        await _unitOfWork.SaveAsync();
                        transaction.Complete();
                        TempData["SuccessMessage"] = "Admin updated successfully";
                        return RedirectToAction(nameof(Index));
                    }

                    foreach(var error in updateUser.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(adminVM);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Models.Admin admin = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Models.Admin? admin = await _unitOfWork.Admin.GetAsync(d => d.Id == id);

            if(admin == null)
            {
                return NotFound();
            }
            await _unitOfWork.Admin.DeleteAsync(admin);
            await _unitOfWork.SaveAsync();
            TempData["SuccessMessage"] = "Admin deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}