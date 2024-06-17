
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Laporan : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Proyek")]
        public string IdProyek { get; set; }

        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Mahasiswa")]
        public string IdMahasiswa { get; set; }

        [Display(Name = "Foto Laporan")]
        public string? FotoLaporan { get; set; }

        [Display(Name = "File Laporan")]
        public string? FileLaporan { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string Keterangan { get; set; }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek Proyek { get; set; }

        [ForeignKey(nameof(IdMahasiswa))]
        [ValidateNever]
        public Mahasiswa Mahasiswa { get; set; }
    }
}
