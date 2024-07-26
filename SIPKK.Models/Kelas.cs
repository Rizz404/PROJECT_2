
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Kelas : CuidTimestampedEntity
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public required string Nama { get; set; }

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string? Deskripsi { get; set; }

        public ICollection<Mahasiswa>? Mahasiswa { get; set; }
    }
}