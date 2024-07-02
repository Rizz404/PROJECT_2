using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Web;
using Visus.Cuid;

namespace SIPKK.Controllers
{
    [Authorize]
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

        public async Task<IActionResult> Laporan()
        {
            string userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if(user == null || mahasiswa == null)
            {
                return NotFound();
            }

            List<Mahasiswa> mahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync(filter: m => m.IdProyek == mahasiswa.IdProyek, includedProperties: [
                m => m.ProgramStudi,
                m => m.Konsentrasi,
                m => m.Proyek      ,
                m => m.BiayaOperasional,
                m => m.Laporan
            ])).ToList();

            return View(mahasiswaList);
        }

        // GET: CreateLaporan
        public async Task<IActionResult> CreateLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            LaporanVM laporanVM = new LaporanVM
            {
                Laporan = new Laporan
                {
                    IdProyek = mahasiswa.IdProyek,
                    IdMahasiswa = mahasiswa.Id
                }
            };

            return View(laporanVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLaporan(LaporanVM laporanVM, IFormFile? fotoLaporan, IFormFile? file)
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

                    laporanVM.Laporan.FotoLaporan = @"\images\laporan\" + filename;
                }

                if(file != null)
                {
                    string filename = new Cuid2().ToString() + Path.GetExtension(file.FileName);
                    string laporanPath = Path.Combine(wwwRootPath, @"images\laporan");

                    using(var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    laporanVM.Laporan.FileLaporan = @"\images\laporan\" + filename;
                }


                Laporan laporan = new()
                {
                    Keterangan = laporanVM.Laporan.Keterangan,
                    IdProyek = laporanVM.Laporan.IdProyek,
                    FotoLaporan = laporanVM.Laporan.FotoLaporan,
                    FileLaporan = laporanVM.Laporan.FileLaporan,
                    IdMahasiswa = laporanVM.Laporan.IdMahasiswa,
                };

                await _unitOfWork.Laporan.CreateAsync(laporan);
                await _unitOfWork.SaveAsync();
                TempData["SuccessMessage"] = "Laporan created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(laporanVM);
        }

        // GET: CreateBiayaOperasional
        public async Task<IActionResult> CreateBiayaOperasional()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            BiayaOperasionalVM biayaOperasionalVM = new BiayaOperasionalVM
            {
                BiayaOperasional = new BiayaOperasional
                {
                    IdProyek = mahasiswa.IdProyek,
                    IdMahasiswa = mahasiswa.Id,
                    TanggalBiaya = DateTime.UtcNow
                }
            };

            return View(biayaOperasionalVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBiayaOperasional(BiayaOperasionalVM biayaOperasionalVM)
        {
            if(ModelState.IsValid)
            {
                BiayaOperasional biayaOperasional = new()
                {
                    IdProyek = biayaOperasionalVM.BiayaOperasional.IdProyek,
                    IdMahasiswa = biayaOperasionalVM.BiayaOperasional.IdMahasiswa,
                    Keterangan = biayaOperasionalVM.BiayaOperasional.Keterangan,
                    BiayaDll = biayaOperasionalVM.BiayaOperasional.BiayaDll,
                    BiayaProyek = biayaOperasionalVM.BiayaOperasional.BiayaProyek,
                    BiayaTransportasi = biayaOperasionalVM.BiayaOperasional.BiayaTransportasi,
                    TanggalBiaya = biayaOperasionalVM.BiayaOperasional.TanggalBiaya,
                };

                await _unitOfWork.BiayaOperasional.CreateAsync(biayaOperasional);
                await _unitOfWork.SaveAsync();
                TempData["SuccessMessage"] = "Biaya Operasional created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(biayaOperasionalVM);
        }

        public IActionResult DownloadLaporan(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                return Content("File path is not provided");
            }

            // Decoding file path
            string decodedFilePath = HttpUtility.UrlDecode(filePath);

            // Lokasi direktori root file laporan
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", decodedFilePath.TrimStart('\\'));

            // Mengecek apakah file ada
            if(!System.IO.File.Exists(path))
            {
                return Content("File not found");
            }

            // Mendapatkan file tipe konten dan nama
            var contentType = "application/octet-stream";
            var fileName = Path.GetFileName(path);

            // Mengunduh file
            return File(System.IO.File.ReadAllBytes(path), contentType, fileName);
        }
    }
}
