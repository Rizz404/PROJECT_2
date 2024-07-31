using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class KelompokVM
    {
        public Kelompok Kelompok { get; set; }
        public string? SearchTerm { get; set; }
        public List<Mahasiswa>? SearchResults { get; set; }
        public List<Mahasiswa>? SelectedMahasiswa { get; set; }
    }
}
