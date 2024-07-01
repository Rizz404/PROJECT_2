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
    public class PendaftaranRepository : Repository<Pendaftaran>, IPendaftaranRepository
    {
        //strukturnya begini jangan macem-macem
        private ApplicationDbContext _db;
        public PendaftaranRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // update type modelnya
        public async Task UpdateAsync(Pendaftaran obj)
        {
            var objFromDb = await _db.Pendaftaran.FirstOrDefaultAsync(m => m.Id == obj.Id);

            if(objFromDb != null)
            {
                objFromDb.IdMahasiswa = obj.IdMahasiswa;
                objFromDb.IdProyek = obj.IdProyek;
                objFromDb.TanggalPendaftaran = obj.TanggalPendaftaran;
                objFromDb.StatusPembayaran = obj.StatusPembayaran;

                if(obj.BuktiPembayaran != null)
                {
                    objFromDb.BuktiPembayaran = obj.BuktiPembayaran;
                }
            }
        }
    }
}
