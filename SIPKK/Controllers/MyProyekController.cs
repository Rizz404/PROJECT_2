using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;

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
            var mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(m => m.IdUser == userId,
                include: q => q.Include(m => m.ProgramStudi).Include(m => m.Konsentrasi).Include(m => m.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Mahasiswa));

            if (mahasiswa == null)
            {
                return NotFound();
            }

            Proyek? myProyek = null;
            Kelompok? myKelompok = null;
            Dosen? myDosen = null;
            if (!string.IsNullOrEmpty(mahasiswa.IdProyekKKP))
            {
                myDosen = await _unitOfWork.Dosen.FindAsync(d => d.IdProyek == mahasiswa.IdProyekKKP);
                myProyek = mahasiswa.Proyek;
            }
            else if (mahasiswa.Kelompok != null)
            {
                myDosen = await _unitOfWork.Dosen.FindAsync(d => d.IdProyek == mahasiswa.Kelompok.IdProyek);
                myKelompok = mahasiswa.Kelompok;
                myProyek = mahasiswa.Kelompok.Proyek;
            }

            var myProyekVM = new MyProyekVM()
            {
                MyKelompok = myKelompok,
                Proyek = myProyek,
                Dosen = myDosen,
                Mahasiswa = mahasiswa
            };

            return View(myProyekVM);
        }

        private async Task<IActionResult> HandleDosenIndex()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.FindAsync(filter: d => d.IdUser == userId);

            Proyek? proyek = null;
            List<Kelompok>? kelompokList = null;

            if (dosen == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(dosen.IdProyek))
            {
                proyek = await _unitOfWork.Proyek.FindAsync(filter: p => p.Id == dosen.IdProyek, include: q => q.Include(p => p.Mahasiswa).Include(p => p.Kelompok).ThenInclude(k => k.Mahasiswa));
            }

            if (proyek != null && proyek.Kelompok != null)
            {
                kelompokList = proyek.Kelompok.ToList(); // Convert HashSet<Kelompok> to List<Kelompok>
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
            var mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(m => m.IdUser == userId,
    include: q => q.Include(m => m.ProgramStudi).Include(m => m.Konsentrasi).Include(m => m.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Proyek));

            if (mahasiswa == null)
            {
                return NotFound();
            }

            List<Laporan>? myLaporan = null;
            if (!string.IsNullOrEmpty(mahasiswa.IdProyekKKP) && mahasiswa.Kelompok == null)
            {
                myLaporan = (List<Laporan>?)await _unitOfWork.Laporan.GetAllAsync(filter: b => b.IdMahasiswa == mahasiswa.Id);
            }
            else if (mahasiswa.Kelompok != null && string.IsNullOrEmpty(mahasiswa.IdProyekKKP))
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
            var dosen = await _unitOfWork.Dosen.FindAsync(filter: d => d.IdUser == userId, include: q => q.Include(d => d.Proyek).ThenInclude(p => p.Mahasiswa).
Include(d => d.Proyek).ThenInclude(k => k.Kelompok).ThenInclude(k => k.Mahasiswa));


            if (dosen == null)
            {
                return NotFound();
            }

            List<Laporan>? myLaporan = null;
            if (!string.IsNullOrEmpty(dosen.IdProyek))
            {
                myLaporan = (List<Laporan>?)await _unitOfWork.Laporan.GetAllAsync(filter: l => l.IdProyek == dosen.IdProyek, includedProperties: [
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

            switch (userRole)
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
            var mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(m => m.IdUser == userId,
    include: q => q.Include(m => m.ProgramStudi).Include(m => m.Konsentrasi).Include(m => m.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Proyek));

            if (mahasiswa == null)
            {
                return NotFound();
            }

            List<BiayaOperasional>? myBiayaOperasional = null;
            if (!string.IsNullOrEmpty(mahasiswa.IdProyekKKP) && mahasiswa.Kelompok == null)
            {
                myBiayaOperasional = (List<BiayaOperasional>?)await _unitOfWork.BiayaOperasional.GetAllAsync(filter: b => b.IdMahasiswa == mahasiswa.Id);
            }
            else if (mahasiswa.Kelompok != null && string.IsNullOrEmpty(mahasiswa.IdProyekKKP))
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
            var dosen = await _unitOfWork.Dosen.FindAsync(filter: d => d.IdUser == userId, include: q => q.Include(d => d.Proyek).ThenInclude(p => p.Mahasiswa).
 Include(d => d.Proyek).ThenInclude(k => k.Kelompok).ThenInclude(k => k.Mahasiswa));


            if (dosen == null)
            {
                return NotFound();
            }

            List<BiayaOperasional>? myBiayaOperasional = null;
            if (!string.IsNullOrEmpty(dosen.IdProyek))
            {
                myBiayaOperasional = (List<BiayaOperasional>?)await _unitOfWork.BiayaOperasional.GetAllAsync(filter: b => b.IdProyek == dosen.IdProyek, includedProperties: [
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
            var mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(m => m.IdUser == userId,
    include: q => q.Include(m => m.ProgramStudi).Include(m => m.Konsentrasi).Include(m => m.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Proyek));

            if (mahasiswa == null)
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
            if (ModelState.IsValid)
            {
                await _unitOfWork.BiayaOperasional.CreateAsync(biayaOperasionalVM.BiayaOperasional);
                await _unitOfWork.SaveAsync();
                TempData["SuccessMessage"] = "Biaya Operasional created successfully";
                return RedirectToAction(nameof(BiayaOperasional));
            }

            return View(biayaOperasionalVM);
        }

        // GET: CreateLaporan
        public async Task<IActionResult> CreateLaporan()
        {
            string userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.FindAsync(m => m.IdUser == userId,
    include: q => q.Include(m => m.ProgramStudi).Include(m => m.Konsentrasi).Include(m => m.Proyek).Include(m => m.Kelompok).ThenInclude(k => k.Proyek));

            if (mahasiswa == null)
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
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file == null || file.Length == 0)
                {
                    ModelState.AddModelError("Laporan.FileLaporan", "File Laporan harus diisi");
                    return View(laporanVM);
                }


                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string laporanPath = Path.Combine(wwwRootPath, @"files\laporan");

                if (!Directory.Exists(laporanPath))
                {
                    Directory.CreateDirectory(laporanPath);
                }

                using (var fileStream = new FileStream(Path.Combine(laporanPath, filename), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                laporanVM.Laporan.FileLaporan = @"\files\laporan\" + filename;

                await _unitOfWork.Laporan.CreateAsync(laporanVM.Laporan);
                await _unitOfWork.SaveAsync();
                TempData["SuccessMessage"] = "Laporan created successfully";
                return RedirectToAction(nameof(Laporan));
            }

            return View(laporanVM);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateNilai(string Id, int nilai)
        {
            if (Id == null || Id == string.Empty)
            {
                return NotFound();
            }

            Mahasiswa updatedMahasiswa = await _unitOfWork.Mahasiswa.FindAsync(filter: d => d.Id == Id);

            if (updatedMahasiswa == null)
            {
                return NotFound();
            }

            updatedMahasiswa.Nilai = nilai;
            await _unitOfWork.Mahasiswa.UpdateAsync(updatedMahasiswa);
            await _unitOfWork.SaveAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateNilaiKelompok(string Id, int nilai)
        {
            if (Id == null || Id == string.Empty)
            {
                return NotFound();
            }

            Kelompok updatedKelompok = await _unitOfWork.Kelompok.FindAsync(filter: d => d.Id == Id);

            if (updatedKelompok == null)
            {
                return NotFound();
            }

            // Update nilai kelompok
            updatedKelompok.Nilai = nilai;
            await _unitOfWork.Kelompok.UpdateAsync(updatedKelompok);

            // Update nilai mahasiswa yang terkait dengan kelompok
            var mahasiswaList = await _unitOfWork.Mahasiswa.GetAllAsync(filter: m => m.IdKelompok == Id);
            foreach (var mahasiswa in mahasiswaList)
            {
                mahasiswa.Nilai = nilai;
                await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
            }

            await _unitOfWork.SaveAsync();

            return RedirectToAction("Index");
        }

    }
}
