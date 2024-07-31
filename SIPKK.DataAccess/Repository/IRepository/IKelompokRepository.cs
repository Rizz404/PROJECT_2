using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository.IRepository
{
    // update genericnya kalo di copy
    public interface IKelompokRepository : IRepository<Kelompok>
    {
        Task UpdateAsync(Kelompok obj);   // update type modelnya
    }
}
