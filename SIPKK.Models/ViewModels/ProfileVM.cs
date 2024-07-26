using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SIPKK.Models.Mahasiswa;

namespace SIPKK.Models.ViewModels
{
    public class ProfileVM
    {

        [ValidateNever]
        public string Id { get; set; }

        [ValidateNever]
        [Display(Name = "Id User")]
        public string IdUser { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string UserName { get; set; }

        [Phone]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string? PhoneNumber { get; set; }

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

        [ValidateNever]
        public string? NIM { get; set; }

        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string? FirstName { get; set; }

        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string? LastName { get; set; }

        [Display(Name = "Foto Profil")]
        public string? FotoProfil { get; set; }

        [ValidateNever]
        [Display(Name = "Program Studi")]
        public string? ProgramStudi { get; set; }

        [ValidateNever]
        [Display(Name = "Konsentrasi")]
        public string? Konsentrasi { get; set; }

        [ValidateNever]
        public string? Angkatan { get; set; }

        [ValidateNever]
        [Display(Name = "Kelas")]
        public string? Kelas { get; set; }

        [ValidateNever]
        [Display(Name = "Id Proyek KKP")]
        public string? ProyekKKP { get; set; }

        [ValidateNever]
        [Display(Name = "Id Kelompok")]
        public string? Kelompok { get; set; }

        [ValidateNever]
        public short? Semester { get; set; }

        [Display(Name = "Role Mahasiswa")]
        public Role? RoleMahasiswa { get; set; }

        [ValidateNever]
        public string? NIDN { get; set; }

        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string? NamaDosen { get; set; }

        [ValidateNever]
        [Display(Name = "Id Proyek")]
        public string? Proyek { get; set; }
    }
}
