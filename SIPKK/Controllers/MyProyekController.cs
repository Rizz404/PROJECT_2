using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;
using Visus.Cuid;

namespace SIPKK.Controllers
{
    public class MyProyekController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MyProyekController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            string userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId, m => m.ProgramStudi, m => m.Konsentrasi, m => m.Proyek);

            if(user == null || mahasiswa == null)
            {
                return NotFound();
            }

            var pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(p => p.IdMahasiswa == mahasiswa.Id);
            var laporan = await _unitOfWork.Laporan.GetAsync(l => l.IdMahasiswa == mahasiswa.Id);
            var biayaOperasional = await _unitOfWork.BiayaOperasional.GetAsync(b => b.IdMahasiswa == mahasiswa.Id);

            var myProyekVM = new MyProyekVM()
            {
                Mahasiswa = mahasiswa,
                Proyek = mahasiswa.Proyek,
                Laporan = laporan,
                Pendaftaran = pendaftaran,
                BiayaOperasional = biayaOperasional
            };

            return View(myProyekVM);
        }

        // get createLaporan
        [Authorize]
        public async Task<IActionResult> CreateLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId, m => m.ProgramStudi, m => m.Konsentrasi, m => m.Proyek);

            if(user == null || mahasiswa == null)
            {
                return NotFound();
            }

            var pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(p => p.IdMahasiswa == mahasiswa.Id);
            var laporan = await _unitOfWork.Laporan.GetAsync(l => l.IdMahasiswa == mahasiswa.Id);

            var myProyekVM = new MyProyekVM()
            {
                Mahasiswa = mahasiswa,
                Proyek = mahasiswa.Proyek,
                Laporan = new Laporan(), // Initialize a new Laporan object
                Pendaftaran = pendaftaran,
                IdMahasiswa = mahasiswa.Id,
                IdProyek = mahasiswa.Proyek.Id
            };

            return View(myProyekVM);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLaporan(MyProyekVM myProyekVM, IFormFile? fotoLaporan, IFormFile? file)
        {
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(fotoLaporan != null)
                {
                    string filename = new Cuid2().ToString() + Path.GetExtension(fotoLaporan.FileName);
                    string laporanPath = Path.Combine(wwwRootPath, @"images\laporan");

                    using(var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
                    {
                        fotoLaporan.CopyTo(fileStream);
                    }

                    myProyekVM.Laporan.FotoLaporan = @"\images\laporan\" + filename;
                }

                if(file != null)
                {
                    string filename = new Cuid2().ToString() + Path.GetExtension(file.FileName);
                    string laporanPath = Path.Combine(wwwRootPath, @"images\laporan");

                    using(var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    myProyekVM.Laporan.FileLaporan = @"\images\laporan\" + filename;
                }

                Laporan laporan = new()
                {
                    Keterangan = myProyekVM.Laporan.Keterangan,
                    IdProyek = myProyekVM.IdProyek,
                    FotoLaporan = myProyekVM.Laporan.FotoLaporan,
                    FileLaporan = myProyekVM.Laporan.FileLaporan,
                    IdMahasiswa = myProyekVM.IdMahasiswa,
                };

                await _unitOfWork.Laporan.CreateAsync(laporan);
                await _unitOfWork.SaveAsync();
                TempData["Success"] = "Laporan created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(myProyekVM);
        }
    }
}
