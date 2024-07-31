using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class AngkatanVM
    {
        public Angkatan Angkatan { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ProgramStudiList { get; set; }
    }
}
