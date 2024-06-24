
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Proyek : CuidTimestampedEntity
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Nama Proyek")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string NamaProyek { get; set; }

        [RegularExpression(@"^(?!.{5}$).*", ErrorMessage = "Deskripsi tidak boleh hanya berisi 5 karakter.")]
        public string? Deskripsi { get; set; }

        [Display(Name = "Foto Proyek")]
        public string? FotoProyek { get; set; }

        private DateTime _tanggalMulai;
        public DateTime TanggalMulai
        {
            get => _tanggalMulai;
            set => _tanggalMulai = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        private DateTime _tanggalSelesai;
        public DateTime TanggalSelesai
        {
            get => _tanggalSelesai;
            set => _tanggalSelesai = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        [MaxLength(100)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(100, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 3)]
        public string Lokasi { get; set; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Kuota")]
        [Range(0, short.MaxValue, ErrorMessage = "Nilai {0} harus di antara {1} dan {2}.")]
        public short Kuota { get; set; }

        [Display(Name = "Verified")]
        public bool? Verified { get; set; }

        [Display(Name = "Sudah Selesai")]
        public bool? SudahSelesai { get; set; }

        public ICollection<Mahasiswa>? Mahasiswa { get; set; }
        public ICollection<Dosen>? Dosen { get; set; }
        public ICollection<Pendaftaran>? Pendaftaran { get; set; }
        public BiayaOperasional? BiayaOperasional { get; set; }
        public Laporan? Laporan { get; set; }
    }
}
