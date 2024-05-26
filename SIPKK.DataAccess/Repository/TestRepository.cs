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
    public class TestRepository : Repository<Test>, ITestRepository
    {
        //strukturnya begini jangan macem-macem
        private AplicationDbContext _db;
        public TestRepository(AplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // update type modelnya
        public async Task UpdateAsync(Test obj)
        {
            var existingEntity = await _db.Test.FindAsync(obj.Id);
            if(existingEntity != null)
            {
                _db.Entry(existingEntity).CurrentValues.SetValues(obj);
                await _db.SaveChangesAsync();
            }
        }
    }
}
