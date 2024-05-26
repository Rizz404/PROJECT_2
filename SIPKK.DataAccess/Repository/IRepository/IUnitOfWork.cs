using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IDosenRepository Dosen { get; }
        void Save();
    }
}
