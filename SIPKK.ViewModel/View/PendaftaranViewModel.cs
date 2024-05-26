using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Abstractions;
using sistem_informasi_pendaftaran_KKN_KKP.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class PendaftaranViewModel : CuidTimestampedEntity
    {
        public string NamaMahasiswa { get; set; }
        public DateTime TanggalPendaftaran { get; set; }
        public string Status { get; set; }
        public string SelectedMahasiswaId { get; set; }
        public IEnumerable<SelectListItem>? MahasiswaOptions { get; set; }
    }
}
