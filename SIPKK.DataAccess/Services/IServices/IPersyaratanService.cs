using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Services.IServices
{
    public interface IPersyaratanService
    {
        Task<List<Persyaratan>> GetAllPersyaratanAsync();
        Task<Persyaratan> GetPersyaratanByIdAsync(string id);
        Task<bool> CreatePersyaratanAsync(Persyaratan persyaratan);
        Task<bool> UpdatePersyaratanAsync(Persyaratan persyaratan);
        Task<bool> DeletePersyaratanAsync(string id);
    }
}
