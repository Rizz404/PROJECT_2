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
    // update generic dan typenya kalo di copy
    public class BiayaOperasionalRepository : Repository<BiayaOperasional>, IBiayaOperasionalRepository
    {
        //strukturnya begini jangan macem-macem
        private AplicationDbContext _db;
        public BiayaOperasionalRepository(AplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // update type modelnya
        public void Update(BiayaOperasional obj)
        {
            _db.BiayaOperasional.Update(obj); // update modelnya
        }
    }
}
