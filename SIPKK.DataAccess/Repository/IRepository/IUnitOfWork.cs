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
        IAngkatanRepository Angkatan { get; }
        IAdminRepository Admin { get; }
        IDosenRepository Dosen { get; }
        IFeedbackRepository Feedback { get; }
        IKelasRepository Kelas { get; }
        IKelompokRepository Kelompok { get; }
        IBiayaOperasionalRepository BiayaOperasional { get; }
        IKonsentrasiRepository Konsentrasi { get; }
        ILaporanRepository Laporan { get; }
        IMahasiswaRepository Mahasiswa { get; }
        IPendaftaranRepository Pendaftaran { get; }
        IPersyaratanRepository Persyaratan { get; }
        IProgramStudiRepository ProgramStudi { get; }
        IProyekRepository Proyek { get; }
        // ya intinya buat async pakai task
        Task SaveAsync();
    }
}
