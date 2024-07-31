
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Feedback : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Dosen")]
        public string IdDosen { get; set; }

        [MaxLength(36)]
        [Display(Name = "Mahasiswa")]
        public string? IdMahasiswa { get; set; } = null;

        [MaxLength(36)]
        [Display(Name = "Kelompok")]
        public string? IdKelompok { get; set; } = null;

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string Comment { get; set; }

        [ForeignKey(nameof(IdDosen))]
        [ValidateNever]
        public Dosen Dosen { get; set; }

        [ForeignKey(nameof(IdMahasiswa))]
        [ValidateNever]
        public Mahasiswa Mahasiswa { get; set; }

        [ForeignKey(nameof(IdKelompok))]
        [ValidateNever]
        public Kelompok Kelompok { get; set; }
    }
}