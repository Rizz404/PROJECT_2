using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using SIPKK.Ultilities;
using System.Transactions;
using Visus.Cuid;

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
        public async Task<IActionResult> Index(string programStudiId, string konsentrasiId, string angkatanId, string kelasId, int? semester, bool? persyaratanTerpenuhi)
        {
            var mahasiswaQuery = await _unitOfWork.Mahasiswa.FindAllAsync(
                include: q => q
                    .Include(m => m.Proyek)
                    .Include(m => m.Kelompok)
                    .Include(m => m.ProgramStudi)
                    .Include(m => m.Konsentrasi)
                    .Include(m => m.Angkatan)
                    .Include(m => m.Kelas)
                    .Include(m => m.Persyaratan)
                    .Include(m => m.Pendaftaran)
            );

            if (!string.IsNullOrEmpty(programStudiId))
            {
                mahasiswaQuery = mahasiswaQuery.Where(m => m.ProgramStudi.Id == programStudiId);
            }

            if (!string.IsNullOrEmpty(konsentrasiId))
            {
                mahasiswaQuery = mahasiswaQuery.Where(m => m.Konsentrasi.Id == konsentrasiId);
            }

            if (!string.IsNullOrEmpty(angkatanId))
            {
                mahasiswaQuery = mahasiswaQuery.Where(m => m.Angkatan.Id == angkatanId);
            }

            if (!string.IsNullOrEmpty(kelasId))
            {
                mahasiswaQuery = mahasiswaQuery.Where(m => m.Kelas.Id == kelasId);
            }

            if (semester.HasValue)
            {
                mahasiswaQuery = mahasiswaQuery.Where(m => m.Semester == semester.Value);
            }

            if (persyaratanTerpenuhi.HasValue)
            {
                mahasiswaQuery = mahasiswaQuery.Where(m =>
                    m.Persyaratan != null &&
                    m.Persyaratan.KetSehat == persyaratanTerpenuhi.Value &&
                    m.Persyaratan.KetPembayaran == persyaratanTerpenuhi.Value &&
                    m.Persyaratan.KetOrangTua == persyaratanTerpenuhi.Value &&
                    m.Persyaratan.KetKelakuanBaik == persyaratanTerpenuhi.Value
                );
            }

            var mahasiswaList = mahasiswaQuery.ToList();

            ViewBag.ProgramStudiList = new SelectList(await _unitOfWork.ProgramStudi.GetAllAsync(), "Id", "Nama");
            ViewBag.KonsentrasiList = new SelectList(await _unitOfWork.Konsentrasi.GetAllAsync(), "Id", "Nama");
            ViewBag.AngkatanList = new SelectList(await _unitOfWork.Angkatan.GetAllAsync(), "Id", "Tahun");
            ViewBag.KelasList = new SelectList(await _unitOfWork.Kelas.GetAllAsync(), "Id", "Nama");
            ViewBag.SemesterList = new SelectList(Enumerable.Range(1, 8));

            return View(mahasiswaList);
        }



        // GET: Mahasiswa/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(filter: m => m.Id == id, include: q => q.
               Include(m => m.Proyek).
               Include(m => m.Kelompok).
               Include(m => m.ProgramStudi).
               Include(m => m.Konsentrasi).
               Include(m => m.Persyaratan).
               Include(m => m.Pendaftaran)
            );

            if (mahasiswa == null)
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
                ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KonsentrasiList = (await _unitOfWork.Konsentrasi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KelompokList = (await _unitOfWork.Kelompok.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaKelompok,
                    Value = p.Id
                }),
                KelasList = (await _unitOfWork.Kelas.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                AngkatanList = (await _unitOfWork.Angkatan.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Tahun,
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

            using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        var existingMahasiswa = await _unitOfWork.Mahasiswa.FindAsync(m => m.NIM == mahasiswaVM.Mahasiswa.NIM);
                        if (existingMahasiswa != null)
                        {
                            TempData["ErrorMessage"] = "Mahasiswa telah ada";
                            return View(mahasiswaVM);
                        }

                        var user = new ApplicationUser
                        {
                            UserName = username,
                            Email = email,
                            EmailConfirmed = true
                        };

                        var createNewUser = await _userManager.CreateAsync(user, password);

                        if (createNewUser.Succeeded)
                        {
                            var addRoleToUser = await _userManager.AddToRoleAsync(user, SD.Role_Mahasiswa);

                            if (addRoleToUser.Succeeded)
                            {
                                Mahasiswa mahasiswa = new()
                                {
                                    IdUser = user.Id,
                                    NIM = mahasiswaVM.Mahasiswa.NIM,
                                    FirstName = mahasiswaVM.Mahasiswa.FirstName,
                                    LastName = mahasiswaVM.Mahasiswa.LastName,
                                    IdKelompok = mahasiswaVM.Mahasiswa.IdKelompok,
                                    IdProgramStudi = mahasiswaVM.Mahasiswa.IdProgramStudi,
                                    IdKonsentrasi = mahasiswaVM.Mahasiswa.IdKonsentrasi,
                                    TanggalLahir = mahasiswaVM.Mahasiswa.TanggalLahir,
                                    FotoProfil = mahasiswaVM.Mahasiswa.FotoProfil,
                                    Semester = mahasiswaVM.Mahasiswa.Semester,
                                };

                                Persyaratan persyaratan = new()
                                {
                                    KetKelakuanBaik = false,
                                    KetOrangTua = false,
                                    KetPembayaran = false,
                                    KetSehat = false,
                                    IdMahasiswa = mahasiswa.Id
                                };

                                await _unitOfWork.Mahasiswa.CreateAsync(mahasiswa);
                                await _unitOfWork.Persyaratan.CreateAsync(persyaratan);
                            }
                            foreach (var error in addRoleToUser.Errors)
                            {
                                ModelState.AddModelError(string.Empty, error.Description);
                            }
                        }
                        foreach (var error in createNewUser.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        await _unitOfWork.SaveAsync();

                        transaction.Complete();
                        TempData["SuccessMessage"] = "Mahasiswa created successfully";
                        return RedirectToAction(nameof(Index));
                    }
                    mahasiswaVM.ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Nama,
                        Value = p.Id
                    });
                    mahasiswaVM.KonsentrasiList = (await _unitOfWork.Konsentrasi.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Nama,
                        Value = p.Id
                    });
                    mahasiswaVM.KelompokList = (await _unitOfWork.Kelompok.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.NamaKelompok,
                        Value = p.Id
                    });
                    mahasiswaVM.KelasList = (await _unitOfWork.Kelas.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Nama,
                        Value = p.Id
                    });
                    mahasiswaVM.AngkatanList = (await _unitOfWork.Angkatan.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Tahun,
                        Value = p.Id
                    });
                    return View(mahasiswaVM);
                }
                catch (Exception)
                {
                    mahasiswaVM.ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Nama,
                        Value = p.Id
                    });
                    mahasiswaVM.KonsentrasiList = (await _unitOfWork.Konsentrasi.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Nama,
                        Value = p.Id
                    });
                    mahasiswaVM.KelompokList = (await _unitOfWork.Kelompok.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.NamaKelompok,
                        Value = p.Id
                    });
                    mahasiswaVM.KelasList = (await _unitOfWork.Kelas.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Nama,
                        Value = p.Id
                    });
                    mahasiswaVM.AngkatanList = (await _unitOfWork.Angkatan.FindAllAsync()).Select(p => new SelectListItem
                    {
                        Text = p.Tahun,
                        Value = p.Id
                    });
                    return View(mahasiswaVM);
                }
            }
        }

        // GET: Mahasiswa/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa? mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(d => d.Id == id);

            if (mahasiswa == null)
            {
                return NotFound();
            }

            MahasiswaVM mahasiswaVM = new()
            {
                Mahasiswa = mahasiswa,
                ProgramStudiList = (await _unitOfWork.ProgramStudi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KonsentrasiList = (await _unitOfWork.Konsentrasi.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KelompokList = (await _unitOfWork.Kelompok.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaKelompok,
                    Value = p.Id
                }),
                KelasList = (await _unitOfWork.Kelas.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                AngkatanList = (await _unitOfWork.Angkatan.FindAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.Tahun,
                    Value = p.Id
                }),
            };

            return View(mahasiswaVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MahasiswaVM mahasiswaVM)
        {
            if (ModelState.IsValid)
            {
                var mahasiswaFromDb = await _unitOfWork.Mahasiswa.FindAsync(d => d.Id == mahasiswaVM.Mahasiswa.Id);
                if (mahasiswaFromDb == null)
                {
                    return NotFound();
                }

                if (await TryUpdateModelAsync(mahasiswaFromDb, "Mahasiswa",
                   m => m.NIM, m => m.FirstName, m => m.LastName, m => m.TanggalLahir, m => m.IdProgramStudi, m => m.IdKonsentrasi, m => m.IdKelompok, m => m.Semester))
                {
                    await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswaFromDb);
                    await _unitOfWork.SaveAsync();
                    TempData["SuccessMessage"] = "Mahasiswa updated successfully";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(mahasiswaVM);
        }

        // GET: Mahasiswa/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(filter: m => m.Id == id,
                include: q => q.
                Include(m => m.Proyek).
                Include(m => m.Kelompok).
                Include(m => m.ProgramStudi).
                Include(m => m.Konsentrasi).
                Include(m => m.Persyaratan).
                Include(m => m.Pendaftaran)
            );

            if (mahasiswa == null)
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
            Mahasiswa? mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(d => d.Id == id);

            if (mahasiswa == null)
            {
                return NotFound();
            }

            string userId = mahasiswa.IdUser;

            ApplicationUser? user = await _userManager.FindByIdAsync(userId);

            using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _unitOfWork.Mahasiswa.DeleteAsync(mahasiswa);
                    await _unitOfWork.SaveAsync();

                    if (user != null)
                    {
                        var result = await _userManager.DeleteAsync(user);

                        if (!result.Succeeded)
                        {
                            TempData["Error"] = "Error deleting user";
                            return RedirectToAction(nameof(Index));
                        }
                    }

                    // Commit transaction
                    transaction.Complete();

                    TempData["SuccessMessage"] = "Mahasiswa deleted successfully";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    TempData["Error"] = "An error occurred while deleting Mahasiswa";
                    return RedirectToAction(nameof(Index));
                }
            }
        }
    }
}