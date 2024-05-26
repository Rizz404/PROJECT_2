using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Abstractions;
using sistem_informasi_pendaftaran_KKN_KKP.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class KonsentrasiViewModel : CuidTimestampedEntity
    {
        public string Nama { get; set; }

        public string? Deskripsi { get; set; }

        public string Prodi { get; set; }

        public IEnumerable<SelectListItem> ProgramOption { get; set; }
    }
}
