using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SIPKK.Ultilities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Pendaftaran : CuidTimestampedEntity
    {
        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Id Mahasiswa")]
        public string IdMahasiswa { get; set; }

        [MaxLength(36)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Id Proyek")]
        public string IdProyek { get; set; }

        private DateTime _tanggalPendaftaran;

        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Tanggal Pendaftaran")]
        public DateTime TanggalPendaftaran
        {
            get => _tanggalPendaftaran;
            set => _tanggalPendaftaran = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        // nanti kasih enum aja
        [Required(ErrorMessage = "{0} harus diisi")]
        [Display(Name = "Status Pembayaran")]
        public bool StatusPembayaran { get; set; }

        [Display(Name = "Bukti Pembayaran")]
        public string? BuktiPembayaran { get; set; }

        [ForeignKey(nameof(IdMahasiswa))]
        [ValidateNever]
        public Mahasiswa Mahasiswa { get; set; }

        [ForeignKey(nameof(IdProyek))]
        [ValidateNever]
        public Proyek Proyek { get; set; }
    }
}
