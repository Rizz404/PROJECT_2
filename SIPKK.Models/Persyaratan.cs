
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Persyaratan : CuidEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Mahasiswa")]
        public string IdMahasiswa { get; set; }

        [DefaultValue(false)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Keterangan Sehat")]
        public bool KetSehat { get; set; }

        [DefaultValue(false)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Keterangan Pembayaran")]
        public bool KetPembayaran { get; set; }

        [DefaultValue(false)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Keterangan Orang Tua")]
        public bool KetOrangTua { get; set; }

        [DefaultValue(false)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Keterangan Kelakuan Baik")]
        public bool KetKelakuanBaik { get; set; }

        [ForeignKey(nameof(IdMahasiswa))]
        public Mahasiswa? Mahasiswa { get; set; }
    }
}
