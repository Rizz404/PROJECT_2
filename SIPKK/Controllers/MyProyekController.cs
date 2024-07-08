using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
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

        public enum UserRole
        {
            Mahasiswa,
            Dosen
        }

        private async Task<UserRole> GetUserRole()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                throw new InvalidOperationException("User not found");

            if (await _userManager.IsInRoleAsync(user, "Mahasiswa"))
                return UserRole.Mahasiswa;
            if (await _userManager.IsInRoleAsync(user, "Dosen"))
                return UserRole.Dosen;

            throw new InvalidOperationException("User role not recognized");
        }

        public async Task<IActionResult> Index()
        {
            var userRole = await GetUserRole();

            switch (userRole)
            {
                case UserRole.Mahasiswa:
                    return await HandleMahasiswaIndex();
                case UserRole.Dosen:
                    return await HandleDosenIndex();
                default:
                    return NotFound();
            }
        }

        private async Task<IActionResult> HandleMahasiswaIndex()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId,
                includedProperties: [m => m.ProgramStudi, m => m.Konsentrasi, m => m.Proyek]);

            if (mahasiswa == null)
            {
                return NotFound();
            }

            var myProyekVM = new MyProyekVM()
            {
                Mahasiswa = mahasiswa,
                Proyek = mahasiswa.Proyek,
                Laporan = await _unitOfWork.Laporan.GetAsync(l => l.IdMahasiswa == mahasiswa.Id),
                Pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(p => p.IdMahasiswa == mahasiswa.Id),
                BiayaOperasional = await _unitOfWork.BiayaOperasional.GetAsync(b => b.IdMahasiswa == mahasiswa.Id),
                Dosen = mahasiswa.Proyek != null ? await _unitOfWork.Dosen.GetAsync(d => d.IdProyek == mahasiswa.Proyek.Id) : null
            };

            return View(myProyekVM);
        }

        private async Task<IActionResult> HandleDosenIndex()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId, includedProperties: [d => d.Proyek]);
            var proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == dosen.IdProyek, includedProperties: [d => d.Mahasiswa]);

            if (dosen == null)
            {
                return NotFound();
            }

            var myProyekDosenVM = new MyProyekVM()
            {
                Dosen = dosen,
                Proyek = proyek
            };

            return View(myProyekDosenVM);
        }


        public async Task<IActionResult> Laporan()
        {
            var userRole = await GetUserRole();

            switch (userRole)
            {
                case UserRole.Mahasiswa:
                    return await HandleMahasiswaLaporan();
                case UserRole.Dosen:
                    return await HandleDosenLaporan();
                default:
                    return NotFound();
            }
        }

        private async Task<IActionResult> HandleMahasiswaLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if (mahasiswa == null || mahasiswa.IdProyek == null)
            {
                TempData["ErrorMessage"] = "Daftar proyek aja belum";
                return Redirect(Request.Headers["Referer"].ToString());
            }

            List<Mahasiswa> mahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync(filter: m => m.IdProyek == mahasiswa.IdProyek, includedProperties: [
                m => m.ProgramStudi,
                m => m.Konsentrasi,
                m => m.Proyek,
                m => m.BiayaOperasional,
                m => m.Laporan
            ])).ToList();

            return View(mahasiswaList);
        }

        private async Task<IActionResult> HandleDosenLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId);

            if (dosen == null || dosen.IdProyek == null)
            {
                TempData["ErrorMessage"] = "Daftar proyek aja belum";
                return Redirect(Request.Headers["Referer"].ToString());
            }

            List<Mahasiswa> mahasiswaList = (await _unitOfWork.Mahasiswa.GetAllAsync(filter: m => m.IdProyek == dosen.IdProyek, includedProperties: [
                 m => m.ProgramStudi,
                m => m.Konsentrasi,
                m => m.Proyek,
                m => m.BiayaOperasional,
                m => m.Laporan
             ])).ToList();

            return View(mahasiswaList);
        }

        // GET: CreateBiayaOperasional
        public async Task<IActionResult> CreateBiayaOperasional()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if (mahasiswa == null)
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
            if (ModelState.IsValid)
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
        // GET: CreateLaporan
        public async Task<IActionResult> CreateLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if (mahasiswa == null)
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
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (fotoLaporan != null)
                {
                    string filename = new Cuid2().ToString() + Path.GetExtension(fotoLaporan.FileName);
                    string laporanPath = Path.Combine(wwwRootPath, @"images\laporan");

                    using (var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
                    {
                        fotoLaporan.CopyTo(fileStream);
                    }

                    laporanVM.Laporan.FotoLaporan = @"\images\laporan\" + filename;
                }

                if (file != null)
                {
                    string filename = new Cuid2().ToString() + Path.GetExtension(file.FileName);
                    string laporanPath = Path.Combine(wwwRootPath, @"images\laporan");

                    using (var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
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


    }
}
