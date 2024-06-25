using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using System.Diagnostics;

namespace SIPKK.Controllers
{
    public class PendaftaranController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PendaftaranController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        protected string GetUserId()
        {
            return _userManager.GetUserId(User);
        }

        public async Task<IActionResult> UploadBiayaPendaftaran(string id)
        {
            var userId = GetUserId();

            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);

            if(mahasiswa == null)
            {
                return NotFound();
            }

            var pendaftaran = new Pendaftaran()
            {
                IdProyek = id,
                IdMahasiswa = mahasiswa.Id,
                StatusPembayaran = false,
                TanggalPendaftaran = DateTime.UtcNow
            };

            var pendaftaranVM = new PendaftaranVM()
            {
                Pendaftaran = pendaftaran
            };

            return View(pendaftaranVM);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadBiayaPendaftaran(PendaftaranVM pendaftaranVM, IFormFile? file)
        {
            if(file == null || file.Length == 0)
            {
                ModelState.AddModelError("Pendaftaran.BuktiPembayaran", "Harus diisi");
            }

            if(ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string buktiPembayaran = Path.Combine(wwwRootPath, @"images\bukti-pembayaran");

                    if(!string.IsNullOrEmpty(pendaftaranVM.Pendaftaran.BuktiPembayaran))
                    {
                        // hapus image old
                        var oldImagePath = Path.Combine(wwwRootPath, pendaftaranVM.Pendaftaran.BuktiPembayaran.TrimStart('\\'));

                        if(System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using(var fileStream = new FileStream(Path.Combine(buktiPembayaran, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    pendaftaranVM.Pendaftaran.BuktiPembayaran = @"\images\bukti-pembayaran\" + filename;
                }
                // Log the TanggalPendaftaran to ensure it is set correctly
                Debug.WriteLine("TanggalPendaftaran: " + pendaftaranVM.Pendaftaran.TanggalPendaftaran.ToString("o")); // ISO 8601 format
                await _unitOfWork.Pendaftaran.CreateAsync(pendaftaranVM.Pendaftaran);
                await _unitOfWork.SaveAsync();
                TempData["ErrorMessage"] = "Berhasil upload bukti pembayaran";
                return Redirect($"/Proyek/Details/{pendaftaranVM.Pendaftaran.IdProyek}");
            }
            return View(pendaftaranVM);
        }
    }
}
