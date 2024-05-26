
using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Abstractions;
using sistem_informasi_pendaftaran_KKN_KKP.Interface;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class PersyaratanViewModel : CuidTimestampedEntity
    {
        public string NamaMahasiswa { get; set; }
        public bool KetSehat { get; set; }
        public bool KetPembayaran { get; set; }
        public bool KetOrangTua { get; set; }
        public bool KetKelakuanBaik { get; set; }
        public IEnumerable<SelectListItem> MahasiswaOptions { get; set; }
    }
}
