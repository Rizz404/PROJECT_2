using Microsoft.AspNetCore.Mvc.Rendering;
using SIPKK.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class ProyekViewInputModel
    {
        public string? Id { get; set; }

        [Required(ErrorMessage ="Nama Proyek Wajib Diisi")]
        [Display(Name ="Nama Proyek")]
        public string NamaProyek { get; set; }

        // int gak bisa pakai max length
        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Keterangan tidak boleh hanya 5 huruf.")]
        public string? Deskripsi { get; set; }

        [Required(ErrorMessage = "Tanggal Mulai diisi")]
        [Display(Name = "Tanggal Mulai")]
        public DateOnly TanggalMulai { get; set; }

        [Required(ErrorMessage = "Tanggal Selesai harus diisi")]
        [Display(Name = "Tanggal Selesai")]
        public DateOnly TanggalSelesai { get; set; }

        [Required(ErrorMessage = "Lokasi harus diisi")]
        [Display(Name = "Lokasi")]
        public string Lokasi { get; set; }


        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Kouta")]
        public string Kuota { get; set; }

      
    }
}
