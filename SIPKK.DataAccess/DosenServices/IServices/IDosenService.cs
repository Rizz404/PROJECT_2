using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.DosenServices.IServices
{
    public interface IDosenService
    {
        Task<List<Dosen>> GetAllDosenAsync();
        Task<Dosen> GetDosenByIdAsync(string id);
        Task<bool> CreateDosenAsync(Dosen dosen);
        Task<bool> UpdateDosenAsync(Dosen dosen);
        Task<bool> DeleteDosenAsync(string id);
        //Task<(bool success, string message)> DaftarProyekAsync(string proyekId, string userId);
    }
}
