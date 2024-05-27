using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Pendaftaran : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Mahasiswa")]
        public string IdMahasiswa { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Pendaftaran")]
        public DateTime TanggalPendaftaran { get; set; }

        // nanti kasih enum aja
        [Required(ErrorMessage = "{0} harus diisi")]
        public string Status { get; set; }

        [ForeignKey(nameof(IdMahasiswa))]
        [ValidateNever]
        public Mahasiswa Mahasiswa { get; set; }
    }
}
