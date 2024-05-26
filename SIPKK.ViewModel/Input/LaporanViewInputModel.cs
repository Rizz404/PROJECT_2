
using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.Abstractions;
using SIPKK.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class LaporanViewInputModel
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string Keterangan { get; set; }

        public string SelectedProyekId { get; set; }
        public IEnumerable<SelectListItem>? ProyekOptions { get; set; }
    }
}
