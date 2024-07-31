using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository.IRepository
{
    // update genericnya kalo di copy
    public interface IKelasRepository : IRepository<Kelas>
    {
        Task UpdateAsync(Kelas obj);   // update type modelnya
    }
}
