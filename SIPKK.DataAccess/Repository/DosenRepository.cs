using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository
{
    public class DosenRepository : Repository<Dosen>, IDosenRepository
    {
        //strukturnya begini jangan macem-macem
        private AplicationDbContext _db;
        public DosenRepository(AplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Dosen obj)
        {
            _db.Dosen.Update(obj);
        }
    }
}
