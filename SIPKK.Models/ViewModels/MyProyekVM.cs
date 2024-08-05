using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SIPKK.Models.ViewModels
{
    public class MyProyekVM
    {
        public Kelompok? MyKelompok { get; set; }

        public ICollection<Kelompok>? KelompokList { get; set; }
        public ICollection<BiayaOperasional>? BiayaOperasionalList { get; set; }
        public ICollection<Laporan>? LaporanList { get; set; }

        [ValidateNever]
        public Dosen? Dosen { get; set; }

        [ValidateNever]
        public Proyek? Proyek { get; set; }

        [ValidateNever]
        public Laporan? Laporan { get; set; }

        [ValidateNever]
        public Pendaftaran? Pendaftaran { get; set; }

        [ValidateNever]
        public BiayaOperasional? BiayaOperasional { get; set; }

        [ValidateNever]
        public Mahasiswa? Mahasiswa { get; set; }

        //// Add these properties
        //public string IdMahasiswa { get; set; }
        //public string IdProyek { get; set; }
    }
}
