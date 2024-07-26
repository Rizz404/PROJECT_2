using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class ProyekVM
    {
        public enum Status
        {
            TIDAK_TERDAFTAR, TERDAFTAR, PENDING, TERDAFTAR_PROYEK_LAIN
        }

        public Proyek Proyek { get; set; }

        [ValidateNever]
        public Status StatusMahasiswa { get; set; }

        [ValidateNever]
        public string? ProyekTerdaftarNameForCurrentMahasiswa { get; set; }

        [ValidateNever]
        public int MahasiswaTerdaftar { get; set; }
    }
}
