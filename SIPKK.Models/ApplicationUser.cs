using Microsoft.AspNetCore.Identity;
using SIPKK.Ultilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visus.Cuid;

namespace SIPKK.Models
{
    public class ApplicationUser : IdentityUser, ITimestampedEntity
    {
        public ApplicationUser()
        {
            Id = new Cuid2().ToString(); // Inisialisasi Id di sini
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
