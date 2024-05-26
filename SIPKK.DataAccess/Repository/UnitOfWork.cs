using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository
{
    //intinya unit of work adalah penghubung untuk bisa mengakses semua repo yang diinginkan
    public class UnitOfWork : IUnitOfWork
    {
        private AplicationDbContext _db;
        public IDosenRepository Dosen { get; private set; }
        public IBiayaOperasionalRepository BiayaOperasional { get; private set; }

        public UnitOfWork(AplicationDbContext db)
        {
            _db = db;
            Dosen = new DosenRepository(_db);
            BiayaOperasional = new BiayaOperasionalRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
