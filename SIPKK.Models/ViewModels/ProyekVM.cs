using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SIPKK.Models.Mahasiswa;

namespace SIPKK.Models.ViewModels
{
    public class ProyekVM
    {
        public enum Status
        {
            TIDAK_TERDAFTAR, TERDAFTAR, TERDAFTAR_PROYEK_LAIN
        }

        public Proyek Proyek { get; set; }

        [ValidateNever]
        public Status StatusTerdaftar { get; set; }

        [ValidateNever]
        public string? ProyekTerdaftarNameForCurrentUser { get; set; }

        [ValidateNever]
        public int MahasiswaTerdaftar { get; set; }

        [ValidateNever]
        public Role? RoleMahasiswa { get; set; }
    }
}
