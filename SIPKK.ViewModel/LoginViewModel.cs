using System.ComponentModel.DataAnnotations;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
