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
    public class PersyaratanService : IPersyaratanService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersyaratanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Persyaratan>> GetAllPersyaratanAsync()
        {
            return (await _unitOfWork.Persyaratan.GetAllAsync()).ToList();
        }

        public async Task<Persyaratan> GetPersyaratanByIdAsync(string id)
        {
            if(string.IsNullOrEmpty(id))
                return null;

            return await _unitOfWork.Persyaratan.GetAsync(d => d.Id == id

            );
        }

        public async Task<bool> CreatePersyaratanAsync(Persyaratan persyaratan)
        {
            try
            {
                await _unitOfWork.Persyaratan.CreateAsync(persyaratan);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdatePersyaratanAsync(Persyaratan persyaratan)
        {
            try
            {
                await _unitOfWork.Persyaratan.UpdateAsync(persyaratan);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePersyaratanAsync(string id)
        {
            try
            {
                Persyaratan persyaratan = await _unitOfWork.Persyaratan.GetAsync(d => d.Id == id);
                if(persyaratan == null)
                    return false;

                await _unitOfWork.Persyaratan.DeleteAsync(persyaratan);
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
