using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        // tambahin interface repo lagi kalo buat lagi
        IDosenRepository Dosen { get; }
        IBiayaOperasionalRepository BiayaOperasional { get; }
        void Save();
    }
}
