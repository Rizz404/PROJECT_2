using SIPKK.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace SIPKK.ViewModels.Input
{
    public class KonsentrasiViewInputModel
    {
        public string? Id { get; set; }

        // int gak bisa pakai max length
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Konsentrasi")]
        public string Nama { get; set; }

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Keterangan tidak boleh hanya 5 huruf.")]
        public string? Deskripsi { get; set; }


        public string SelectedProgramId { get; set; }
        public IEnumerable<SelectListItem>? ProgramOption { get; set; }
    }
}
