using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.Abstractions;
using SIPKK.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class PendaftaranViewInputModel
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Pendaftaran")]
        public DateTime TanggalPendaftaran { get; set; }

        // nanti kasih enum aja
        [Required(ErrorMessage = "{0} harus diisi")]
        public string Status { get; set; }

        public string SelectedMahasiswaId { get; set; }
        public IEnumerable<SelectListItem>? MahasiswaOptions { get; set; }
    }
}
