
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Dosen : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [ValidateNever]
        public string IdUser { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string NamaDosen { get; set; }

        [MaxLength(36)]
        [Display(Name = "Proyek")]
        public string? IdProyek { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(10, ErrorMessage = "harus 10 karakter", MinimumLength = 10)]
        [RegularExpression(@"^\d+$", ErrorMessage = "Hanya boleh diisi dengan angka.")]
        public string NIDN { get; set; }

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

        [ForeignKey(nameof(IdUser))]
        [ValidateNever]
        public ApplicationUser User { get; set; }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek Proyek { get; set; }
    }
}
