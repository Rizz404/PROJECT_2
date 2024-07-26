// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Models.ViewModels;
using SIPKK.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace SIPKK.Areas.Identity.Pages.Account
{
    public class RegisterModelMahasiswa : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly ILogger<RegisterModelMahasiswa> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterModelMahasiswa(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModelMahasiswa> logger,
            IEmailSender emailSender, IUnitOfWork unitOfWork)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [MaxLength(10)]
            [Required(ErrorMessage = "{0} harus diisi")]
            [StringLength(10, ErrorMessage = "harus 10 karakter", MinimumLength = 10)]
            [RegularExpression(@"^\d+$", ErrorMessage = "Hanya boleh diisi dengan angka.")]
            public string NIM { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [DataType(DataType.Date)]
            [Required(ErrorMessage = "{0} harus diisi")]
            [Display(Name = "Tanggal Lahir")]
            public DateTime TanggalLahir { get; set; }

            [MaxLength(36)]
            [Required(ErrorMessage = "{0} harus diisi")]
            [Display(Name = "Program Studi")]
            public string IdProgramStudi { get; set; }

            [MaxLength(36)]
            [Required(ErrorMessage = "{0} harus diisi")]
            [Display(Name = "Konsentrasi")]
            public string IdKonsentrasi { get; set; }

            [MaxLength(36)]
            [Required(ErrorMessage = "{0} harus diisi")]
            [Display(Name = "Kelas")]
            public string IdKelas { get; set; }

            [MaxLength(36)]
            [Required(ErrorMessage = "{0} harus diisi")]
            [Display(Name = "Angkatan")]
            public string IdAngkatan { get; set; }

            [ValidateNever]
            public IEnumerable<SelectListItem> ProgramStudiList { get; set; }

            [ValidateNever]
            public IEnumerable<SelectListItem> KonsentrasiList { get; set; }

            [ValidateNever]
            public IEnumerable<SelectListItem> KelasList { get; set; }

            [ValidateNever]
            public IEnumerable<SelectListItem> AngkatanList { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if(_unitOfWork == null)
            {
                _logger.LogError("UnitOfWork is not initialized.");
                return;
            }

            var programStudi = await _unitOfWork.ProgramStudi.GetAllAsync();
            var konsentrasi = await _unitOfWork.Konsentrasi.GetAllAsync();
            var kelas = await _unitOfWork.Kelas.GetAllAsync();
            var angkatan = await _unitOfWork.Angkatan.GetAllAsync();

            if(programStudi == null || konsentrasi == null || kelas == null || angkatan == null)
            {
                _logger.LogError("One or more lists are null.");
                return;
            }

            Input = new InputModel
            {
                ProgramStudiList = programStudi.Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KonsentrasiList = konsentrasi.Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                KelasList = kelas.Select(p => new SelectListItem
                {
                    Text = p.Nama,
                    Value = p.Id
                }),
                AngkatanList = angkatan.Select(p => new SelectListItem
                {
                    Text = p.Tahun,
                    Value = p.Id
                })
            };

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if(ModelState.IsValid)
            {
                var user = CreateUser();

                user.UserName = Input.Username;
                user.Email = Input.Email;

                var result = await _userManager.CreateAsync(user, Input.Password);

                if(result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    var addRoleToUser = await _userManager.AddToRoleAsync(user, SD.Role_Mahasiswa);

                    if(addRoleToUser.Succeeded)
                    {
                        Mahasiswa mahasiswa = new()
                        {
                            IdUser = user.Id,
                            NIM = Input.NIM,
                            FirstName = Input.FirstName,
                            LastName = Input.LastName,
                            TanggalLahir = Input.TanggalLahir,
                            IdProgramStudi = Input.IdProgramStudi,
                            IdKonsentrasi = Input.IdKonsentrasi,
                            IdKelas = Input.IdKelas,
                            IdAngkatan = Input.IdAngkatan,
                        };
                        Persyaratan persyaratan = new()
                        {
                            KetKelakuanBaik = false,
                            KetOrangTua = false,
                            KetPembayaran = false,
                            KetSehat = false,
                            IdMahasiswa = mahasiswa.Id
                        };

                        await _unitOfWork.Mahasiswa.CreateAsync(mahasiswa);
                        await _unitOfWork.Persyaratan.CreateAsync(persyaratan);
                    }
                    foreach(var error in addRoleToUser.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    await _unitOfWork.SaveAsync();

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if(_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if(!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
