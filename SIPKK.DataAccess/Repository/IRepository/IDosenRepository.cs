using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository.IRepository
{
    public interface IDosenRepository : IRepository<Dosen>
    {
        void Update(Dosen obj);
    }
}
