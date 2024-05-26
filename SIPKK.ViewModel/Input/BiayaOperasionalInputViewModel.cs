using SIPKK.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class BiayaOperasionalInputViewModel
    {
        public string? Id { get; set; }

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

        public string SelectedProyekId { get; set; }
        public IEnumerable<SelectListItem>? ProyekOptions { get; set; }
    }
}
