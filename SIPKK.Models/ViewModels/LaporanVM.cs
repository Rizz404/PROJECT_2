using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIPKK.Models.ViewModels
{
    public class LaporanVM
    {
        public Laporan Laporan { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ProyekList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> MahasiswaList { get; set; }
        public bool IsUpdate { get; set; }
    }
}
