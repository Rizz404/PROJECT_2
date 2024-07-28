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
            if(user == null)
                throw new InvalidOperationException("User not found");

            if(await _userManager.IsInRoleAsync(user, "Mahasiswa"))
                return UserRole.Mahasiswa;
            if(await _userManager.IsInRoleAsync(user, "Dosen"))
                return UserRole.Dosen;

            throw new InvalidOperationException("User role not recognized");
        }

        public async Task<IActionResult> Index()
        {
            var userRole = await GetUserRole();

            switch(userRole)
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
                includedProperties: [m => m.ProgramStudi, m => m.Konsentrasi, m => m.Kelompok]);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            Proyek? myProyek = null;
            if(!string.IsNullOrEmpty(mahasiswa.IdProyekKKP))
            {
                myProyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == mahasiswa.IdProyekKKP, includedProperties: [d => d.Mahasiswa]);
            }
            else if(mahasiswa.Kelompok != null)
            {
                myProyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == mahasiswa.Kelompok.IdProyek, includedProperties: [d => d.Mahasiswa]);
            }

            var myKelompok = await _unitOfWork.Kelompok.GetAsync(k => k.Id == mahasiswa.IdKelompok, includedProperties: [k => k.Mahasiswa]);

            var myProyekVM = new MyProyekVM()
            {
                MyKelompok = myKelompok,
                Proyek = myProyek,
                Laporan = await _unitOfWork.Laporan.GetAsync(l => l.IdMahasiswa == mahasiswa.Id),
                Pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(p => p.IdMahasiswa == mahasiswa.Id),
                BiayaOperasional = await _unitOfWork.BiayaOperasional.GetAsync(b => b.IdMahasiswa == mahasiswa.Id),
                Dosen = mahasiswa.Proyek != null ? await _unitOfWork.Dosen.GetAsync(d => d.IdProyek == mahasiswa.Proyek.Id) : null,
                Mahasiswa = mahasiswa
            };

            return View(myProyekVM);
        }

        private async Task<IActionResult> HandleDosenIndex()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId, includedProperties: [d => d.Proyek]);

            if(dosen == null)
            {
                return NotFound();
            }

            Proyek proyek = null;
            if(!string.IsNullOrEmpty(dosen.IdProyek))
            {
                await _unitOfWork.Proyek.GetAsync(d => d.Id == dosen.IdProyek, includedProperties: [d => d.Mahasiswa]);
            }

            List<Kelompok> kelompokList = null;
            if(proyek != null && proyek.TipeProyek == Proyek.Tipe.KKN)
            {
                kelompokList = (List<Kelompok>)await _unitOfWork.Kelompok.GetAllAsync(k => k.IdProyek == proyek.Id);
            }


            var myProyekDosenVM = new MyProyekVM()
            {
                Dosen = dosen,
                Proyek = proyek,
                KelompokList = kelompokList
            };

            return View(myProyekDosenVM);
        }


        public async Task<IActionResult> Laporan()
        {
            var userRole = await GetUserRole();

            switch(userRole)
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
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId,
                includedProperties: [m => m.ProgramStudi, m => m.Konsentrasi, m => m.Kelompok]);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            List<Laporan>? myLaporan = null;
            if(!string.IsNullOrEmpty(mahasiswa.IdProyekKKP) && mahasiswa.Kelompok == null)
            {
                myLaporan = (List<Laporan>?)await _unitOfWork.Laporan.GetAllAsync(filter: b => b.IdMahasiswa == mahasiswa.Id);
            }
            else if(mahasiswa.Kelompok != null && string.IsNullOrEmpty(mahasiswa.IdProyekKKP))
            {
                myLaporan = (List<Laporan>?)await _unitOfWork.Laporan.GetAllAsync(filter: b => b.IdKelompok == mahasiswa.IdKelompok);
            }

            MyProyekVM myProyekVM = new()
            {
                LaporanList = myLaporan,
                Mahasiswa = mahasiswa,
                MyKelompok = mahasiswa.Kelompok
            };

            return View(myProyekVM);
        }

        private async Task<IActionResult> HandleDosenLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId, includedProperties: [
                d => d.Proyek
            ]);

            if(dosen == null)
            {
                return NotFound();
            }

            List<Laporan>? myLaporan = null;
            if(!string.IsNullOrEmpty(dosen.IdProyek))
            {
                myLaporan = (List<Laporan>?)await _unitOfWork.Laporan.GetAllAsync(filter: b => b.IdMahasiswa == dosen.Id, includedProperties: [
                    b => b.Mahasiswa,
                    b => b.Kelompok
                ]);
            }

            MyProyekVM myProyekVM = new()
            {
                LaporanList = myLaporan,
                Dosen = dosen,
            };

            return View(myProyekVM);
        }

        public async Task<IActionResult> BiayaOperasional()
        {
            var userRole = await GetUserRole();

            switch(userRole)
            {
                case UserRole.Mahasiswa:
                return await HandleMahasiswaBiayaOperasional();
                case UserRole.Dosen:
                return await HandleDosenBiayaOperasional();
                default:
                return NotFound();
            }
        }

        private async Task<IActionResult> HandleMahasiswaBiayaOperasional()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId,
                includedProperties: [m => m.ProgramStudi, m => m.Konsentrasi, m => m.Kelompok]);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            List<BiayaOperasional>? myBiayaOperasional = null;
            if(!string.IsNullOrEmpty(mahasiswa.IdProyekKKP) && mahasiswa.Kelompok == null)
            {
                myBiayaOperasional = (List<BiayaOperasional>?)await _unitOfWork.BiayaOperasional.GetAllAsync(filter: b => b.IdMahasiswa == mahasiswa.Id);
            }
            else if(mahasiswa.Kelompok != null && string.IsNullOrEmpty(mahasiswa.IdProyekKKP))
            {
                myBiayaOperasional = (List<BiayaOperasional>?)await _unitOfWork.BiayaOperasional.GetAllAsync(filter: b => b.IdKelompok == mahasiswa.IdKelompok);
            }

            MyProyekVM myProyekVM = new()
            {
                BiayaOperasionalList = myBiayaOperasional,
                Mahasiswa = mahasiswa,
                MyKelompok = mahasiswa.Kelompok
            };

            return View(myProyekVM);
        }

        private async Task<IActionResult> HandleDosenBiayaOperasional()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId, includedProperties: [
                d => d.Proyek
            ]);

            if(dosen == null)
            {
                return NotFound();
            }

            List<BiayaOperasional>? myBiayaOperasional = null;
            if(!string.IsNullOrEmpty(dosen.IdProyek))
            {
                myBiayaOperasional = (List<BiayaOperasional>?)await _unitOfWork.BiayaOperasional.GetAllAsync(filter: b => b.IdMahasiswa == dosen.Id, includedProperties: [
                    b => b.Mahasiswa,
                    b => b.Kelompok
                ]);
            }

            MyProyekVM myProyekVM = new()
            {
                BiayaOperasionalList = myBiayaOperasional,
                Dosen = dosen,
            };

            return View(myProyekVM);
        }

        // GET: CreateBiayaOperasional
        public async Task<IActionResult> CreateBiayaOperasional()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId,
                includedProperties: [m => m.ProgramStudi, m => m.Konsentrasi, m => m.Kelompok]);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            BiayaOperasionalVM biayaOperasionalVM = new BiayaOperasionalVM
            {
                BiayaOperasional = new BiayaOperasional
                {
                    IdProyek = !string.IsNullOrEmpty(mahasiswa.IdProyekKKP) ? mahasiswa.IdProyekKKP : mahasiswa.Kelompok.IdProyek,
                    IdMahasiswa = mahasiswa.Id,
                    IdKelompok = mahasiswa.IdKelompok,
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
                await _unitOfWork.BiayaOperasional.CreateAsync(biayaOperasionalVM.BiayaOperasional);
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
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId,
                includedProperties: [m => m.ProgramStudi, m => m.Konsentrasi, m => m.Kelompok]);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            LaporanVM laporanVM = new LaporanVM
            {
                Laporan = new Laporan
                {
                    IdProyek = !string.IsNullOrEmpty(mahasiswa.IdProyekKKP) ? mahasiswa.IdProyekKKP : mahasiswa.Kelompok.IdProyek,
                    IdMahasiswa = mahasiswa.Id,
                    IdKelompok = mahasiswa.IdKelompok
                }
            };

            return View(laporanVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLaporan(LaporanVM laporanVM, IFormFile? file)
        {
            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(file == null || file.Length == 0)
                {
                    ModelState.AddModelError("Laporan.FileLaporan", "File Laporan harus diisi");
                    return View(laporanVM);
                }


                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string laporanPath = Path.Combine(wwwRootPath, @"files\laporan");

                if(!Directory.Exists(laporanPath))
                {
                    Directory.CreateDirectory(laporanPath);
                }

                using(var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                laporanVM.Laporan.FileLaporan = @"\files\laporan\" + filename;

                await _unitOfWork.Laporan.CreateAsync(laporanVM.Laporan);
                await _unitOfWork.SaveAsync();
                TempData["SuccessMessage"] = "Laporan created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(laporanVM);
        }
    }
}
