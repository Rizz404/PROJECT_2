using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class PendaftaranVM
    {
        [ValidateNever]
        public Pendaftaran Pendaftaran { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> MahasiswaList { get; set; }
    }
}
