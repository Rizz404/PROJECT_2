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
    public class KelompokController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public KelompokController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        protected string GetUserId()
        {
            return _userManager.GetUserId(User);
        }

        public async Task<IActionResult> Create(string id)
        {
            var userId = GetUserId();

            var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.IdUser == userId, includedProperties: [
                m => m.Persyaratan,
                ]);

            if(mahasiswa == null)
            {
                return NotFound();
            }


            var errorMessages = new List<string>();

            if(mahasiswa.RoleMahasiswa == Mahasiswa.Role.ANGGOTA)
            {
                errorMessages.Add("Kamu bukan ketua, silahkan mengubah role di profile untuk dapat membuat kelompok");
            }
            if(mahasiswa.Persyaratan.KetPembayaran == false)
            {
                errorMessages.Add("Kamu belum menyerahkan bukti pembayaran");
            }
            if(mahasiswa.Persyaratan.KetOrangTua == false)
            {
                errorMessages.Add("Kamu belum menyerahkan bukti persetujuan orang tua");
            }
            if(mahasiswa.Persyaratan.KetKelakuanBaik == false)
            {
                errorMessages.Add("Kamu belum menyerahkan bukti kelakuan baik");
            }
            if(mahasiswa.Persyaratan.KetSehat == false)
            {
                errorMessages.Add("Kamu belum menyerahkan bukti keterangan sehat");
            }

            if(errorMessages.Any())
            {
                TempData["ErrorMessage"] = errorMessages;
                return Redirect(Request.Headers["Referer"].ToString());
            }

            var Kelompok = new Kelompok()
            {
                IdProyek = id,
                NamaKetua = mahasiswa.FirstName + " " + mahasiswa.LastName,
                Nilai = 0,
            };

            var KelompokVM = new KelompokVM()
            {
                Kelompok = Kelompok
            };

            return View(KelompokVM);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KelompokVM kelompokVM)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Kelompok.CreateAsync(kelompokVM.Kelompok);
                await _unitOfWork.SaveAsync();

                var userId = GetUserId();
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(filter: m => m.IdUser == userId);

                if(mahasiswa != null)
                {
                    mahasiswa.IdKelompok = kelompokVM.Kelompok.Id;
                    await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                    await _unitOfWork.SaveAsync();
                }

                TempData["SuccessMessage"] = "Berhasil membuat kelompok menunggu konfirmasi admin";
                return Redirect($"/Proyek/Details/{kelompokVM.Kelompok.IdProyek}");
            }
            return View(kelompokVM);
        }
    }
}
