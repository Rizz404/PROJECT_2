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
using Visus.Cuid;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = nameof(Admin))]
    public class MahasiswaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public MahasiswaController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Mahasiswa
        public async Task<IActionResult> Index()
        {
            List<Mahasiswa> mahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync(m => m.Proyek, m => m.ProgramStudi, m => m.Konsentrasi, m => m.Persyaratan, m => m.Pendaftaran)).ToList();
            return View(mahasiswaList);
        }

        // GET: Mahasiswa/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(d => d.Id == id);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            return View(mahasiswa);
        }

        // GET: Mahasiswa/Create
        public async Task<IActionResult> Create()
        {
            MahasiswaVM mahasiswaVM = new()
            {
                ProgramStudiList = (await _unitOfWork.ProgramStudi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KonsentrasiList = (await _unitOfWork.Konsentrasi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(mahasiswaVM);
        }

        // POST: Mahasiswa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MahasiswaVM mahasiswaVM)
        {
            string[] namaMahasiswaArr = mahasiswaVM.Mahasiswa.FirstName.Split(" ");

            // Buat username, email, dan password
            string username = namaMahasiswaArr.Length > 1 ? namaMahasiswaArr[0] + "_" + new Cuid2().ToString() : mahasiswaVM.Mahasiswa.FirstName + "_" + new Cuid2().ToString();
            string email = $"{mahasiswaVM.Mahasiswa.NIM}@global.ac.id";
            string password = "123456789"; // nanti ganti ke tanggal lahir aja

            if(ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = username,
                    Email = email,
                    EmailConfirmed = true
                };
                var createNewUser = await _userManager.CreateAsync(user, password);

                if(createNewUser.Succeeded)
                {
                    var addRoleToUser = await _userManager.AddToRoleAsync(user, SD.Role_Mahasiswa);

                    if(addRoleToUser.Succeeded)
                    {
                        Mahasiswa mahasiswa = new()
                        {
                            IdUser = user.Id,
                            NIM = mahasiswaVM.Mahasiswa.NIM,
                            FirstName = mahasiswaVM.Mahasiswa.FirstName,
                            LastName = mahasiswaVM.Mahasiswa.LastName,
                            IdProyek = mahasiswaVM.Mahasiswa.IdProyek,
                            IdProgramStudi = mahasiswaVM.Mahasiswa.IdProgramStudi,
                            IdKonsentrasi = mahasiswaVM.Mahasiswa.IdKonsentrasi,
                            TanggalLahir = mahasiswaVM.Mahasiswa.TanggalLahir,
                            FotoProfil = mahasiswaVM.Mahasiswa.FotoProfil,
                            Semester = mahasiswaVM.Mahasiswa.Semester,
                        };
                        await _unitOfWork.Mahasiswa.CreateAsync(mahasiswa);
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
                TempData["Success"] = "Mahasiswa created successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                mahasiswaVM.ProgramStudiList = (await _unitOfWork.ProgramStudi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                });
                mahasiswaVM.KonsentrasiList = (await _unitOfWork.Konsentrasi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                });
                mahasiswaVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(mahasiswaVM);
            }
        }

        // GET: Mahasiswa/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa? mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(d => d.Id == id);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            MahasiswaVM mahasiswaVM = new()
            {
                Mahasiswa = mahasiswa,
                ProgramStudiList = (await _unitOfWork.ProgramStudi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KonsentrasiList = (await _unitOfWork.Konsentrasi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
            };

            return View(mahasiswaVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MahasiswaVM mahasiswaVM)
        {
            if(ModelState.IsValid)
            {
                Debug.WriteLine(mahasiswaVM.Mahasiswa);
                await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswaVM.Mahasiswa);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Mahasiswa updated successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                mahasiswaVM.ProgramStudiList = (await _unitOfWork.ProgramStudi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                });
                mahasiswaVM.KonsentrasiList = (await _unitOfWork.Konsentrasi.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                });
                mahasiswaVM.ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                });
                return View(mahasiswaVM);
            }
        }

        // GET: Mahasiswa/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(d => d.Id == id);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            return View(mahasiswa);
        }

        // POST: Mahasiswa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            Mahasiswa? mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(d => d.Id == id);

            if(mahasiswa == null)
            {
                return NotFound();
            }
            await _unitOfWork.Mahasiswa.DeleteAsync(mahasiswa);
            await _unitOfWork.SaveAsync();
            TempData["Success"] = "Mahasiswa deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}