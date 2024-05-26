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

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Biaya")]
        public DateTime TanggalBiaya { get; set; }

        [ForeignKey(nameof(IdProyek))]
        public Proyek? Proyek { get; set; }

    }
}
