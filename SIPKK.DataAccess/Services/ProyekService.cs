using SIPKK.DataAccess.Repository;
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

    public class ProyekService : IProyekService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProyekService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Proyek>> GetAllProyekAsync()
        {
            return (await _unitOfWork.Proyek.GetAllAsync(p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan)).ToList();
        }

        public async Task<Proyek> GetProyekByIdAsync(string id)
        {
            if(string.IsNullOrEmpty(id))
                return null;

            return await _unitOfWork.Proyek.GetAsync(d => d.Id == id,
                 p => p.Mahasiswa,
                p => p.Dosen,
                p => p.BiayaOperasional,
                p => p.Laporan
            );
        }

        public async Task<bool> CreateProyekAsync(Proyek proyek)
        {
            try
            {
                await _unitOfWork.Proyek.CreateAsync(proyek);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateProyekAsync(Proyek proyek)
        {
            try
            {
                await _unitOfWork.Proyek.UpdateAsync(proyek);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProyekAsync(string id)
        {
            try
            {
                Proyek proyek = await _unitOfWork.Proyek.GetAsync(d => d.Id == id);
                if(proyek == null)
                    return false;

                await _unitOfWork.Proyek.DeleteAsync(proyek);
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
