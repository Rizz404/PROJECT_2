using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models.ViewModels
{
    public class UserRoleData
    {
        public string Id { get; set; }
        public Proyek Proyek { get; set; }
        public Persyaratan Persyaratan { get; set; }
        public Kelompok Kelompok { get; set; }

        public Mahasiswa Mahasiswa { get; set; }
        public Dosen Dosen { get; set; }
        public Admin Admin { get; set; }
    }
}
