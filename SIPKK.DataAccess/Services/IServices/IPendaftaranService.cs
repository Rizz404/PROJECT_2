using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Services.IServices
{
    public interface IPendaftaranService
    {
        Task<List<Pendaftaran>> GetAllPendaftaranAsync();
        Task<Pendaftaran> GetPendaftaranByIdAsync(string id);
        Task<bool> CreatePendaftaranAsync(Pendaftaran pendaftaran);
        Task<bool> UpdatePendaftaranAsync(Pendaftaran pendaftaran);
        Task<bool> DeletePendaftaranAsync(string id);
    }
}
