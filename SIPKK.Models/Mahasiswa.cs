using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Mahasiswa : CuidTimestampedEntity
    {
        [ValidateNever]
        public string IdUser { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(10, ErrorMessage = "harus 10 karakter", MinimumLength = 10)]
        [RegularExpression(@"^\d+$", ErrorMessage = "Hanya boleh diisi dengan angka.")]
        public string NIM { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string LastName { get; set; }

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

        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Program Studi")]
        public string IdProgramStudi { get; set; }

        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Konsentrasi")]
        public string IdKonsentrasi { get; set; }

        [MaxLength(36)]
        [Display(Name = "Nama Proyek")]
        public string? IdProyek { get; set; }

        [Range(1, 12, ErrorMessage = "Semester harus di antara 1 sampai 12")]
        [Required(ErrorMessage = "Semester harus diisi")]
        public short Semester { get; set; }

        [ForeignKey(nameof(IdUser))]
        [ValidateNever]
        public ApplicationUser User { get; set; }

        [ForeignKey(nameof(IdProgramStudi))]
        [ValidateNever]
        public ProgramStudi ProgramStudi { get; set; }

        [ForeignKey(nameof(IdKonsentrasi))]
        [ValidateNever]
        public Konsentrasi Konsentrasi { get; set; }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek? Proyek { get; set; }

        public Pendaftaran? Pendaftaran { get; set; }
        public Laporan? Laporan { get; set; }
        public Persyaratan? Persyaratan { get; set; }
        public BiayaOperasional? BiayaOperasional { get; set; }

        // Custom validation method for Tanggal Lahir
        public static ValidationResult? ValidateTanggalLahir(DateTime tanggalLahir, ValidationContext context)
        {
            if (tanggalLahir > DateTime.Now)
            {
                return new ValidationResult("Tanggal Lahir tidak boleh di masa depan.");
            }
            return ValidationResult.Success;
        }
    }
}
