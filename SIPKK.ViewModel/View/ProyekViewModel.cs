using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Abstractions;
using sistem_informasi_pendaftaran_KKN_KKP.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class ProyekViewModel : CuidTimestampedEntity
    {
        public int BiayaTransportasi { get; set; }

        public int BiayaProyek { get; set; }

        public int BiayaDll { get; set; }

        public string? Keterangan { get; set; }

        public DateTime TanggalBiaya { get; set; }

        public string NamaProyek { get; set; }

        public IEnumerable<SelectListItem> ProyekOptions { get; set; }
    }
}
