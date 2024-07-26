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
        private ApplicationDbContext _db;
        public IAdminRepository Admin { get; private set; }
        public IDosenRepository Dosen { get; private set; }
        public IBiayaOperasionalRepository BiayaOperasional { get; private set; }
        public IKonsentrasiRepository Konsentrasi { get; private set; }
        public ILaporanRepository Laporan { get; private set; }
        public IMahasiswaRepository Mahasiswa { get; private set; }
        public IPendaftaranRepository Pendaftaran { get; private set; }
        public IPersyaratanRepository Persyaratan { get; private set; }
        public IProgramStudiRepository ProgramStudi { get; private set; }
        public IProyekRepository Proyek { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Admin = new AdminRepository(_db);
            Dosen = new DosenRepository(_db);
            BiayaOperasional = new BiayaOperasionalRepository(_db);
            Konsentrasi = new KonsentrasiRepository(_db);
            Laporan = new LaporanRepository(_db);
            Mahasiswa = new MahasiswaRepository(_db);
            Pendaftaran = new PendaftaranRepository(_db);
            Persyaratan = new PersyaratanRepository(_db);
            ProgramStudi = new ProgramStudiRepository(_db);
            Proyek = new ProyekRepository(_db);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
