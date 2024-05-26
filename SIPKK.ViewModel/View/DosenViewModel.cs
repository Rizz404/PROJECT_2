using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Models;
using System.ComponentModel.DataAnnotations;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class DosenViewModel
    {
        public string Id { get; set; }
        public string NamaDosen { get; set; }
        public string Password { get; set; }
        public string NIDN { get; set; }
        public string Username { get; set; }
        public string NamaProyek { get; set; }
        public IEnumerable<SelectListItem> ProyekOptions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
