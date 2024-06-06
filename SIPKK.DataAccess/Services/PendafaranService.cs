using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.Services.IServices;
using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Services
{
    public class PendaftaranService : IPendaftaranService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PendaftaranService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Pendaftaran>> GetAllPendaftaranAsync()
        {
            return (await _unitOfWork.Pendaftaran.GetAllAsync(m => m.Proyek, m => m.Mahasiswa)).ToList();
        }

        public async Task<Pendaftaran> GetPendaftaranByIdAsync(string id)
        {
            if(string.IsNullOrEmpty(id))
                return null;

            return await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == id,
              m => m.Proyek, m => m.Mahasiswa
            );
        }

        public async Task<bool> CreatePendaftaranAsync(Pendaftaran pendaftaran)
        {
            try
            {
                await _unitOfWork.Pendaftaran.CreateAsync(pendaftaran);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdatePendaftaranAsync(Pendaftaran pendaftaran)
        {
            try
            {
                await _unitOfWork.Pendaftaran.UpdateAsync(pendaftaran);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePendaftaranAsync(string id)
        {
            try
            {
                Pendaftaran pendaftaran = await _unitOfWork.Pendaftaran.GetAsync(d => d.Id == id);
                if(pendaftaran == null)
                    return false;

                await _unitOfWork.Pendaftaran.DeleteAsync(pendaftaran);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
