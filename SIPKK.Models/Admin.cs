using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;

namespace SIPKK.Models
{
    public class Admin : CuidTimestampedEntity
    {
        //public string? Id { get; set; }

        public string IdUser { get; set; }

        // Don't forget to add it in database 
        [MaxLength(50)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 5)]
        public string Username { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(50, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 5)]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(255, ErrorMessage = "{0} harus diantara {2} sampai {1}.", MinimumLength = 7)]
        public string Password { get; set; }
    }
}