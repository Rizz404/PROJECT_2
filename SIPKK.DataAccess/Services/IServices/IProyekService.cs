using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Services.IServices
{
    public interface IProyekService
    {
        Task<List<Proyek>> GetAllProyekAsync();
        Task<Proyek> GetProyekByIdAsync(string id);
    }
}
