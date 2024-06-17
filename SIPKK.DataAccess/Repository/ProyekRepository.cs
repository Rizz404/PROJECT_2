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
    public class ProyekRepository : Repository<Proyek>, IProyekRepository
    {
        //strukturnya begini jangan macem-macem
        private ApplicationDbContext _db;
        public ProyekRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // update type modelnya
        public async Task UpdateAsync(Proyek obj)
        {
            var objFromDb = await _db.Proyek.FirstOrDefaultAsync(m => m.Id == obj.Id);

            if(objFromDb != null)
            {
                objFromDb.NamaProyek = obj.NamaProyek;
                objFromDb.Deskripsi = obj.Deskripsi;
                objFromDb.TanggalMulai = obj.TanggalMulai;
                objFromDb.TanggalSelesai = obj.TanggalSelesai;
                objFromDb.Lokasi = obj.Lokasi;
                objFromDb.Kuota = obj.Kuota;

                if(obj.FotoProyek != null)
                {
                    objFromDb.FotoProyek = obj.FotoProyek;
                }
            }
        }
    }
}
