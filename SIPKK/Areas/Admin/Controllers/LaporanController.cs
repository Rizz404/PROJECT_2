using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;

namespace SIPKK.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = nameof(Admin))]
    [Route("Admin/[controller]/[action]")]
    public class LaporanController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LaporanController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Laporan
        public async Task<IActionResult> Index()
        {
            List<Laporan> laporanList = (await _unitOfWork.Laporan.GetAllAsync(includedProperties: [m => m.Mahasiswa])).ToList();
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

        // GET: Laporan/Create
        public async Task<IActionResult> Create()
        {
            LaporanVM LaporanVM = new()
            {
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
                MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                }),

            };

            return View(LaporanVM);
        }

        // POST: Laporan/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LaporanVM laporanVM, IFormFile? file)
        {
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(file != null)
                {
                    string filename2 = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string filePath = Path.Combine(wwwRootPath, @"file\laporan");

                    if(!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }

                    using(var fileStream = new FileStream(Path.Combine(filePath, filename2), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    laporanVM.Laporan.FileLaporan = @"\file\laporan\" + filename2;
                }
                await _unitOfWork.Laporan.CreateAsync(laporanVM.Laporan);
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

        // GET: Laporan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Laporan? Laporan = await _unitOfWork.Laporan.GetAsync(d => d.Id == id);

            if(Laporan == null)
            {
                return NotFound();
            }

            LaporanVM LaporanVM = new()
            {
                Laporan = Laporan,
                ProyekList = (await _unitOfWork.Proyek.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.NamaProyek,
                    Value = p.Id
                }),
                MahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync()).Select(p => new SelectListItem
                {
                    Text = p.FirstName,
                    Value = p.Id
                }),

            };

            return View(LaporanVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LaporanVM laporanVM, IFormFile? file)
        {
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(file != null)
                {
                    string filename2 = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string filePath = Path.Combine(wwwRootPath, @"file\laporan");

                    if(!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }

                    using(var fileStream = new FileStream(Path.Combine(filePath, filename2), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    laporanVM.Laporan.FileLaporan = @"\file\laporan\" + filename2;
                }
                await _unitOfWork.Laporan.UpdateAsync(laporanVM.Laporan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Laporan updated successfully";
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