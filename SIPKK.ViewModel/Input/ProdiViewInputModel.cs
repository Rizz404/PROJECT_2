using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class ProdiViewInputModel
    {
        public string? Id { get; set; }

        // int gak bisa pakai max length
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Nama Prodi")]
        public string Nama { get; set; }

        

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Keterangan tidak boleh hanya 5 huruf.")]
        public string? Deskripsi { get; set; }

    }
}
