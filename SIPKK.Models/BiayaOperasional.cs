using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class BiayaOperasional : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Proyek")]
        public string IdProyek { get; set; }

        // int gak bisa pakai max length
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Biaya Transportasi")]
        public int BiayaTransportasi { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Biaya Proyek")]
        public int BiayaProyek { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Biaya Dll")]
        public int BiayaDll { get; set; }

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Keterangan tidak boleh hanya 5 huruf.")]
        public string? Keterangan { get; set; }

        [NotMapped]
        private DateTime _tanggalBiaya;
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Biaya")]
        public DateTime TanggalBiaya
        {
            get => _tanggalBiaya;
            set => _tanggalBiaya = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek Proyek { get; set; }

    }
}
