using Microsoft.EntityFrameworkCore;
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
    public class LaporanRepository : Repository<Laporan>, ILaporanRepository
    {
        //strukturnya begini jangan macem-macem
        private ApplicationDbContext _db;
        public LaporanRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // update type modelnya
        public async Task UpdateAsync(Laporan obj)
        {
            var objFromDb = await _db.Laporan.FirstOrDefaultAsync(m => m.Id == obj.Id);

            if(objFromDb != null)
            {
                objFromDb.IdProyek = obj.IdProyek;
                objFromDb.IdMahasiswa = obj.IdMahasiswa;
                objFromDb.Keterangan = obj.Keterangan;

                if(obj.FileLaporan != null)
                {
                    objFromDb.FileLaporan = obj.FileLaporan;
                }
            }
        }
    }
}
