using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class MahasiswaVM
    {
        public Mahasiswa Mahasiswa { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ProgramStudiList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> KonsentrasiList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ProyekList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> KelasList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> AngkatanList { get; set; }
    }
}
