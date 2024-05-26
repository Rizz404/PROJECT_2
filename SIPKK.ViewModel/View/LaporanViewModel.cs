
using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Abstractions;
using sistem_informasi_pendaftaran_KKN_KKP.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class LaporanViewModel : CuidTimestampedEntity
    {
        public string Keterangan { get; set; }

        public string NamaProyek { get; set; }
        public IEnumerable<SelectListItem> ProyekOptions { get; set; }
    }
}
