using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;

namespace SIPKK.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var proyekList = await _unitOfWork.Proyek.GetAllAsync(
                p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan
            );
            return View(proyekList);
        }

        public async Task<IActionResult> Details(string id)
        {
            if(id == null || id == string.Empty)
            {
                return NotFound();
            }

            Proyek proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id, p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan
            );

            if(proyek == null)
            {
                return NotFound();
            }

            return View(proyek);
        }

        [Authorize]
        public async Task<IActionResult> Daftar(string id)
        {
            if(string.IsNullOrEmpty(id))
                return NotFound();

            // Mengambil UserId dari pengguna yang saat ini login
            var userId = _userManager.GetUserId(User);
            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);
            var proyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == id);
            var persyaratan = await _unitOfWork.Persyaratan.GetAsync(p => p.IdMahasiswa == mahasiswa.Id);

            if(persyaratan == null)
            {
                var newPersyaratan = new Persyaratan()
                {
                    KetKelakuanBaik = false,
                    KetOrangTua = false,
                    KetSehat = false,
                    KetPembayaran = false
                };

                await _unitOfWork.Persyaratan.CreateAsync(newPersyaratan);
            }

            if(persyaratan.KetPembayaran == false || persyaratan.KetKelakuanBaik == false || persyaratan.KetOrangTua == false || persyaratan.KetSehat == false)
            {

            }


            if(mahasiswa == null || proyek == null || proyek.Kuota <= 0)
            {
                return mahasiswa == null || proyek == null ? NotFound() : (IActionResult)BadRequest("Kuota proyek sudah penuh.");
            }

            // Menambahkan mahasiswa ke proyek
            mahasiswa.IdProyek = proyek.Id;
            proyek.Kuota -= 1;

            try
            {
                await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                await _unitOfWork.Proyek.UpdateAsync(proyek);
                await _unitOfWork.SaveAsync();
            }
            catch(Exception)
            {
                // Log error di sini dan kembalikan respon yang sesuai
                // Contoh: logger.LogError(ex, "Terjadi kesalahan saat mendaftar mahasiswa ke proyek.");
                return StatusCode(500, "Terjadi kesalahan internal saat mendaftar mahasiswa ke proyek.");
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
