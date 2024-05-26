using System.ComponentModel.DataAnnotations;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} tidak boleh kosong")]
        [Compare("Password", ErrorMessage = "Password tidak sama")]
        public string ConfirmPassword { get; set; }

        public string? Address { get; set; }
    }
}
