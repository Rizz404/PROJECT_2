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
    public class MahasiswaRepository : Repository<Mahasiswa>, IMahasiswaRepository
    {
        //strukturnya begini jangan macem-macem
        private ApplicationDbContext _db;
        public MahasiswaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // update type modelnya
        public async Task UpdateAsync(Mahasiswa obj)
        {
            var objFromDb = await _db.Mahasiswa.FirstOrDefaultAsync(m => m.Id == obj.Id);

            if(objFromDb != null)
            {
                objFromDb.NIM = obj.NIM;
                objFromDb.FirstName = obj.FirstName;
                objFromDb.LastName = obj.LastName;
                objFromDb.TanggalLahir = obj.TanggalLahir;
                objFromDb.IdProgramStudi = obj.IdProgramStudi;
                objFromDb.IdKonsentrasi = obj.IdKonsentrasi;
                objFromDb.IdProyek = obj.IdProyek;
                objFromDb.IdUser = obj.IdUser;
                objFromDb.Semester = obj.Semester;

                if(obj.FotoProfil != null)
                {
                    objFromDb.FotoProfil = obj.FotoProfil;
                }
            }
        }
    }
}
