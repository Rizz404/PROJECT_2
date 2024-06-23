using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class ProfileDosenVM
    {
        //public ApplicationUser User { get; set; }
        //public Mahasiswa Mahasiswa { get; set; 

        [ValidateNever]
        public string Id { get; set; }

        [ValidateNever]
        public string NIDN { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string NamaDosen { get; set; }
        [NotMapped]
        private DateTime _tanggalLahir;
        [DataType(DataType.Date, ErrorMessage = "Tanggal Lahir tidak valid.")]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Lahir")]
        public DateTime TanggalLahir
        {
            get => _tanggalLahir;
            set => _tanggalLahir = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        [Display(Name = "Foto Profil")]
        public string? FotoProfil { get; set; }

        [ValidateNever]
        [Display(Name = "Program Studi")]
        public string ProgramStudi { get; set; }

  
        [ValidateNever]
        [Display(Name = "Proyek")]
        public string? Proyek { get; set; }

        [ValidateNever]
        [Display(Name = "Id User")]
        public string IdUser { get; set; }

      
        [EmailAddress]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Phone]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string? PhoneNumber { get; set; }

        //[DataType(DataType.Password)]
        //public string Password { get; set; }


        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Password dan konfirmasi password tidak cocok")]
        //public string ConfirmPassword { get; set; }
    }
}
