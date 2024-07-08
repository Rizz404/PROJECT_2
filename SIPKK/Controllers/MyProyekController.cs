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
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId, m => m.ProgramStudi, m => m.Konsentrasi, m => m.Proyek);

            if(mahasiswa == null)
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

        private async Task<IActionResult> HandleDosenIndex()
        {
            string userId = _userManager.GetUserId(User);
            var dosen = await _unitOfWork.Dosen.GetAsync(d => d.IdUser == userId, d => d.Proyek);

            if(dosen == null)
            {
                return NotFound();
            }

            var myProyekDosenVM = new MyProyekVM()
            {
                Dosen = dosen,
                Proyek = dosen.Proyek,
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
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if(mahasiswa == null || mahasiswa.IdProyek == null)
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

            if(dosen == null || dosen.IdProyek == null)
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
    }
}
