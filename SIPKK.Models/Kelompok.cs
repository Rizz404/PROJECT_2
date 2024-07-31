
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
        [Display(Name = "Nama Ketua")]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string NamaKetua { get; set; }

        [MaxLength(100)]
        [Display(Name = "Nama Kelompok")]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string NamaKelompok { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        public int Kuota { get; set; } = 5;

        public int? Nilai { get; set; }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek Proyek { get; set; }

        public ICollection<Mahasiswa>? Mahasiswa { get; set; }
        public ICollection<Feedback>? Feedback { get; set; }
        public ICollection<Laporan>? Laporan { get; set; }
        public ICollection<BiayaOperasional>? BiayaOperasional { get; set; }
    }
}