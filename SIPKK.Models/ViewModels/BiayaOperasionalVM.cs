using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class BiayaOperasionalVM
    {
        public BiayaOperasional BiayaOperasional { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ProyekList { get; set; }
        [ValidateNever]
        public bool IsUpdate { get; set; }
    }
}
