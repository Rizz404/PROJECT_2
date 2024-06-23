using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.DataAccess.DosenServices.IServices;
using SIPKK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SIPKK.DataAccess.DosenServices
{
    public class DosenService : IDosenService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DosenService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Dosen>> GetAllDosenAsync()
        {
            return (await _unitOfWork.Dosen.GetAllAsync(m => m.Proyek,m => m.IdProyek)).ToList();
        }

        public async Task<Dosen> GetDosenByIdAsync(string id)
        {
            if(string.IsNullOrEmpty(id))
                return null;

            return await _unitOfWork.Dosen.GetAsync(d => d.Id == id,
              m => m.Proyek
            );
        }

        public async Task<bool> CreateDosenAsync(Dosen dosen)
        {
            try
            {
                await _unitOfWork.Dosen.CreateAsync(dosen);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateDosenAsync(Dosen dosen)
        {
            try
            {
                await _unitOfWork.Dosen.UpdateAsync(dosen);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteDosenAsync(string id)
        {
            try
            {
                Dosen dosen = await _unitOfWork.Dosen.GetAsync(d => d.Id == id);
                if(dosen == null)
                    return false;


                await _unitOfWork.Dosen.DeleteAsync(dosen);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

       /* public async Task<(bool success, string message)> DaftarProyekAsync(string proyekId, string userId)
        {
            using(var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var mahasiswa = await _unitOfWork.Mahasiswa.GetAsync(m => m.IdUser == userId);
                if(mahasiswa == null)
                    return (false, "Mahasiswa tidak ditemukan");

                var proyek = await _unitOfWork.Proyek.GetAsync(p => p.Id == proyekId);
                if(proyek == null)
                    return (false, "Proyek tidak ditemukan");
                if(proyek.Kuota <= 0)
                    return (false, "Kuota proyek sudah penuh");

                var persyaratan = await _unitOfWork.Persyaratan.GetAsync(p => p.IdMahasiswa == mahasiswa.Id);
                if(persyaratan == null)
                {
                    persyaratan = new Persyaratan
                    {
                        IdMahasiswa = mahasiswa.Id,
                        KetKelakuanBaik = false,
                        KetOrangTua = false,
                        KetSehat = false,
                        KetPembayaran = false
                    };
                    await _unitOfWork.Persyaratan.CreateAsync(persyaratan);
                    await _unitOfWork.SaveAsync();
                }

                if(!persyaratan.KetPembayaran || !persyaratan.KetKelakuanBaik || !persyaratan.KetOrangTua || !persyaratan.KetSehat)
                {
                    return (false, "Syarat belum lengkap");
                }

                mahasiswa.IdProyek = proyek.Id;
                proyek.Kuota -= 1;

                try
                {
                    await _unitOfWork.Mahasiswa.UpdateAsync(mahasiswa);
                    await _unitOfWork.Proyek.UpdateAsync(proyek);

                    var pendaftaran = new Pendaftaran
                    {
                        IdMahasiswa = mahasiswa.Id,
                        IdProyek = proyek.Id,
                        TanggalPendaftaran = DateTime.UtcNow,
                        Status = "PENDING",
                    };

                    Debug.WriteLine(pendaftaran);
                    await _unitOfWork.Pendaftaran.CreateAsync(pendaftaran);
                    await _unitOfWork.SaveAsync();

                    scope.Complete(); // Commit transaction

                    return (true, "Pendaftaran berhasil");
                }
                catch(Exception ex)
                {
                    return (false, "Terjadi kesalahan internal saat mendaftar mahasiswa ke proyek");
                }
            }
        }*/
    }
}
