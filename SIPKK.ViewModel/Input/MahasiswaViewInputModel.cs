using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.Abstractions;
using SIPKK.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class MahasiswaViewInputModel
    {
        public string? Id { get; set; }

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

        [DataType(DataType.Date, ErrorMessage = "Tanggal Lahir tidak valid.")]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Lahir")]
        public DateTime TanggalLahir { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(255, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 7)]
        public string Password { get; set; }

        public string? FotoProfil { get; set; }

        [Range(1, 12, ErrorMessage = "Semester harus di antara 1 sampai 12")]
        [Required(ErrorMessage = "Semester harus diisi")]
        public short Semester { get; set; }

        public string SelectedProyekId { get; set; }
        public IEnumerable<SelectListItem>? ProyekOptions { get; set; }
        public string SelectedProgramStudiId { get; set; }
        public IEnumerable<SelectListItem>? StudiOptions { get; set; }
        public string SelectedKonsentrasiId { get; set; }
        public IEnumerable<SelectListItem>? KonsentrasiOptions { get; set; }

        // Custom validation method for Tanggal Lahir
        public static ValidationResult? ValidateTanggalLahir(DateTime tanggalLahir, ValidationContext context)
        {
            if(tanggalLahir > DateTime.Now)
            {
                return new ValidationResult("Tanggal Lahir tidak boleh di masa depan.");
            }
            return ValidationResult.Success;
        }
    }
}
