using SIPKK.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.ViewModels.Input
{
    public class AdminViewInputModel
    {
        public string? Id { get; set; }

        // int gak bisa pakai max length
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Password")]
        public string Password { get; set; }


    }
}
