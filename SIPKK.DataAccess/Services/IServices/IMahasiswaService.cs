using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Services.IServices
{
    public interface IDosenService
    {
        Task<List<Mahasiswa>> GetAllMahasiswaAsync();
        Task<Mahasiswa> GetMahasiswaByIdAsync(string id);
        Task<bool> CreateMahasiswaAsync(Mahasiswa mahasiswa);
        Task<bool> UpdateMahasiswaAsync(Mahasiswa mahasiswa);
        Task<bool> DeleteMahasiswaAsync(string id);
        Task<(bool success, string message)> DaftarProyekAsync(string proyekId, string userId);
    }
}
