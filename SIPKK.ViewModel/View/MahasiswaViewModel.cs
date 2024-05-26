using Microsoft.AspNetCore.Mvc.Rendering;
using sistem_informasi_pendaftaran_KKN_KKP.Abstractions;
using sistem_informasi_pendaftaran_KKN_KKP.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistem_informasi_pendaftaran_KKN_KKP.ViewModels.View
{
    public class MahasiswaViewModel : ITimestampedEntity
    {
        public string Id { get; set; }
        public string NIM { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Password { get; set; }
        public string? FotoProfil { get; set; }
        public short Semester { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string NamaProyek { get; set; }
        public IEnumerable<SelectListItem>? ProyekOptions { get; set; }
        public string NamaProgramStudi { get; set; }
        public IEnumerable<SelectListItem>? StudyOptions { get; set; }
        public string NamaKonsentrasi { get; set; }
        public IEnumerable<SelectListItem>? KonsentrasiId { get; set; }
    }
}
