
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Kelompok : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Id Proyek")]
        public string IdProyek { get; set; }

        [MaxLength(100)]
        [Display(Name = "Nama Kelompok")]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public required string NamaKelompok { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Biaya Transportasi")]
        public int Nilai { get; set; }


        public ICollection<Mahasiswa> Mahasiswa { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
    }
}