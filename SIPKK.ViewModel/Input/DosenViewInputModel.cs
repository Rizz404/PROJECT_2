using System.ComponentModel.DataAnnotations;

namespace SIPKK.ViewModels.Input
{
    public class DosenViewInputModel
    {
        public string? Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Nama Dosen")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string NamaDosen { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(255, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 7)]
        public string Password { get; set; }

        [MaxLength(13)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(13, ErrorMessage = "NIDN harus terdiri dari 13 karakter.", MinimumLength = 13)]
        public string NIDN { get; set; }
        public string SelectedProyekId { get; set; }
        public IEnumerable<SelectListItem>? ProyekOptions { get; set; }
    }
}
