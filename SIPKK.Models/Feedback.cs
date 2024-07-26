
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Feedback : CuidTimestampedEntity
    {
        //public string Id { get; set; }

        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Dosen")]
        public required string IdDosen { get; set; }

        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Kelompok")]
        public required string IdKelompok { get; set; }

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string Comment { get; set; }

        [ForeignKey(nameof(IdDosen))]
        [ValidateNever]
        public Dosen Dosen { get; set; }

        [ForeignKey(nameof(IdKelompok))]
        [ValidateNever]
        public Kelompok Kelompok { get; set; }

        public ICollection<Mahasiswa>? Mahasiswa { get; set; }
    }
}