
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Laporan : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Id Proyek")]
        public string IdProyek { get; set; }

        [MaxLength(36)]
        [Display(Name = "Id Mahasiswa")]
        public string IdMahasiswa { get; set; }

        [MaxLength(36)]
        [Display(Name = "Id Kelompok")]
        public string? IdKelompok { get; set; }

        [Display(Name = "File Laporan")]
        public string? FileLaporan { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string Keterangan { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        public bool Status { get; set; }

        public string? Feedback { get; set; }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek Proyek { get; set; }

        [ForeignKey(nameof(IdKelompok))]
        [ValidateNever]
        public Kelompok Kelompok { get; set; }

        [ForeignKey(nameof(IdMahasiswa))]
        [ValidateNever]
        public Mahasiswa Mahasiswa { get; set; }
    }
}
