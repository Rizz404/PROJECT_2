
using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.Abstractions;
using SIPKK.Interface;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class PersyaratanViewInputModel
    {
        public string Id { get; set; }

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
        public string SelectedMahasiswaId { get; set; }
        public IEnumerable<SelectListItem>? MahasiswaOptions { get; set; }
    }
}
