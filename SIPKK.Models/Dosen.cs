
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIPKK.Models
{
    public class Dosen : CuidTimestampedEntity
    {
        public string IdUser { get; set; }

        public string NamaDosen { get; set; }

        public string IdProyek { get; set; }

        public string NIDN { get; set; }


        [ForeignKey(nameof(IdProyek))]
        public Proyek? Proyek { get; set; }
    }
}
