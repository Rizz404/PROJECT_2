using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIPKK.Models;
using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Visus.Cuid;

namespace SIPKK.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //harus add reference ke masing masing class library yang berhubungan intinya
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //! Defaultnya bakal plural hati-hati penamaannya
        //jangan lupa nambahin kalo ada db baru
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Angkatan> Angkatan { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Persyaratan> Persyaratan { get; set; }
        public DbSet<Proyek> Proyek { get; set; }
        public DbSet<Mahasiswa> Mahasiswa { get; set; }
        public DbSet<Dosen> Dosen { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Kelas> Kelas { get; set; }
        public DbSet<Kelompok> Kelompok { get; set; }
        public DbSet<ProgramStudi> ProgramStudi { get; set; }
        public DbSet<Konsentrasi> Konsentrasi { get; set; }
        public DbSet<Pendaftaran> Pendaftaran { get; set; }
        public DbSet<BiayaOperasional> BiayaOperasional { get; set; }
        public DbSet<Laporan> Laporan { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Konfigurasi untuk properti string Id
            foreach(var entityType in builder.Model.GetEntityTypes())
            {
                if(typeof(ICuidEntity).IsAssignableFrom(entityType.ClrType))
                {
                    builder.Entity(entityType.ClrType).Property("Id").HasMaxLength(50).ValueGeneratedNever();
                }

                if(typeof(ITimestampedEntity).IsAssignableFrom(entityType.ClrType))
                {
                    builder.Entity(entityType.ClrType).Property("CreatedAt").IsRequired();
                    builder.Entity(entityType.ClrType).Property("UpdatedAt").IsRequired();
                }
            }

            // Tambahkan dummy data untuk ProgramStudi jika belum ada
            if(!builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(ProgramStudi)))
            {
                var programStudiData = new[]
                {
                    new { Nama = "Teknik Informatika", Deskripsi = "Program studi yang mempelajari ilmu komputer dan teknologi informasi" },
                    new { Nama = "Sistem Informasi", Deskripsi = "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi" },
                    new { Nama = "Bisnis Digital", Deskripsi = "Program studi yang mempelajari manajemen dan administrasi bisnis digital" },
                };

                var programStudiEntities = new List<ProgramStudi>();
                var programStudiIds = new List<string>();

                foreach(var data in programStudiData)
                {
                    var id = new Cuid2().ToString();
                    programStudiIds.Add(id);
                    programStudiEntities.Add(new ProgramStudi
                    {
                        Id = id,
                        Nama = data.Nama,
                        Deskripsi = data.Deskripsi,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });
                }

                builder.Entity<ProgramStudi>().HasData(programStudiEntities);

                // Tambahkan dummy data untuk Konsentrasi jika ProgramStudi sudah ada
                if(!builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Konsentrasi)))
                {
                    var konsentrasiData = new[]
                    {
                        new { Nama = "Software Engineering", Deskripsi = "Deskripsi Konsentrasi 1 TI", IdProgramStudi = programStudiIds[0] },
                        new { Nama = "Computer Networking", Deskripsi = "Deskripsi Konsentrasi 1 SI", IdProgramStudi = programStudiIds[0] },
                        new { Nama = "Business Digital", Deskripsi = "Deskripsi Konsentrasi 1 MB", IdProgramStudi = programStudiIds[2] },
                        new { Nama = "Testing", Deskripsi = "Deskripsi Konsentrasi 1 AK", IdProgramStudi = programStudiIds[2] }
                    };

                    var konsentrasiEntities = konsentrasiData.Select(data => new Konsentrasi
                    {
                        Id = new Cuid2().ToString(),
                        IdProgramStudi = data.IdProgramStudi,
                        Nama = data.Nama,
                        Deskripsi = data.Deskripsi,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }).ToList();

                    builder.Entity<Konsentrasi>().HasData(konsentrasiEntities);
                }
            }

            if(!builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Angkatan)))
            {
                var angkatanData = new[]
                {
                        new { Tahun = "2022", Deskripsi = "Deskripsi Angkatan 1 TI"},
                        new { Tahun = "2023", Deskripsi = "Deskripsi Angkatan 1 SI"},
                        new { Tahun = "2024", Deskripsi = "Deskripsi Angkatan 1 MB"},
                        new { Tahun = "2025", Deskripsi = "Deskripsi Angkatan 1 AK"}
                    };

                var angkatanEntities = angkatanData.Select(data => new Angkatan
                {
                    Id = new Cuid2().ToString(),
                    Tahun = data.Tahun,
                    Deskripsi = data.Deskripsi,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }).ToList();

                builder.Entity<Angkatan>().HasData(angkatanEntities);
            }

            if(!builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Kelas)))
            {
                var kelasData = new[]
                {
                        new { Nama = "2022", Deskripsi = "Deskripsi Kelas 1 TI"},
                        new { Nama = "2023", Deskripsi = "Deskripsi Kelas 1 SI"},
                        new { Nama = "2024", Deskripsi = "Deskripsi Kelas 1 MB"},
                        new { Nama = "2025", Deskripsi = "Deskripsi Kelas 1 AK"}
                    };

                var kelasEntities = kelasData.Select(data => new Kelas
                {
                    Id = new Cuid2().ToString(),
                    Nama = data.Nama,
                    Deskripsi = data.Deskripsi,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }).ToList();

                builder.Entity<Kelas>().HasData(kelasEntities);
            }

            // Tambahkan dummy data untuk Proyek jika belum ada
            if(!builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Proyek)))
            {
                var proyekData = new[]
                {
                    new { NamaProyek = "Proyek KKN Pemberdayaan Perempuan", Deskripsi = "Proyek KKN ini bertujuan untuk memberdayakan perempuan di Desa Mandiri melalui pelatihan keterampilan dan pemberian modal usaha.", TipeProyek = Models.Proyek.Tipe.KKN, Kuota = 16, Lokasi = "Garut" },
                    new { NamaProyek = "Proyek KKN Pengembangan UMKM", Deskripsi = "Proyek KKN ini bertujuan untuk mengembangkan UMKM di Desa Sejahtera melalui pelatihan dan pemberian modal usaha.", TipeProyek = Models.Proyek.Tipe.KKN, Kuota = 20, Lokasi = "Jakarta" },
                    new { NamaProyek = "Proyek KKN Kesehatan Ibu dan Anak", Deskripsi = "Proyek KKN ini bertujuan untuk meningkatkan kesehatan ibu dan anak di Desa Sejahtera melalui program pemeriksaan kesehatan dan edukasi.", TipeProyek = Models.Proyek.Tipe.KKN, Kuota = 8, Lokasi = "Pekalongan" },
                    new { NamaProyek = "Proyek KKN Pengolahan Air Bersih", Deskripsi = "Proyek KKN ini bertujuan untuk menyediakan air bersih di Desa Bersih melalui program penyediaan fasilitas air bersih dan edukasi masyarakat.", TipeProyek = Models.Proyek.Tipe.KKN, Kuota = 32, Lokasi = "Papua" },
                    new { NamaProyek = "Proyek KKP Literasi Digital", Deskripsi = "Proyek KKP ini bertujuan untuk meningkatkan literasi digital masyarakat di Kota Pintar melalui pelatihan dan seminar.", TipeProyek = Models.Proyek.Tipe.KKP, Kuota = 16, Lokasi = "Garut" },
                    new { NamaProyek = "Proyek KKP Pendidikan Anak", Deskripsi = "Proyek KKP ini bertujuan untuk meningkatkan kualitas pendidikan anak di Kota Pintar melalui program bimbingan belajar dan penyediaan fasilitas belajar.", TipeProyek = Models.Proyek.Tipe.KKP, Kuota = 20, Lokasi = "Jakarta" },
                    new { NamaProyek = "Proyek KKP Keterampilan Anak Muda", Deskripsi = "Proyek KKP ini bertujuan untuk mengembangkan keterampilan anak muda di Kota Kreatif melalui berbagai pelatihan dan workshop.", TipeProyek = Models.Proyek.Tipe.KKP, Kuota = 8, Lokasi = "Pekalongan" },
                    new { NamaProyek = "Proyek KKP Teknologi Pertanian", Deskripsi = "Proyek KKP ini bertujuan untuk mengembangkan teknologi pertanian di Desa Tani melalui program pelatihan dan penerapan teknologi modern.", TipeProyek = Models.Proyek.Tipe.KKP, Kuota = 32, Lokasi = "Papua" }
                };

                var proyekEntities = proyekData.Select(data => new Proyek
                {
                    Id = new Cuid2().ToString(),
                    NamaProyek = data.NamaProyek,
                    Deskripsi = data.Deskripsi,
                    TipeProyek = data.TipeProyek,
                    Kuota = (short)data.Kuota,
                    Lokasi = data.Lokasi,
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(6),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }).ToList();

                builder.Entity<Proyek>().HasData(proyekEntities);
            }
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries<ICuidEntity>())
            {
                if(entry.State == EntityState.Added)
                {
                    if(entry.Entity is ITimestampedEntity timestampedEntity)
                    {
                        timestampedEntity.CreatedAt = DateTime.UtcNow;
                        timestampedEntity.UpdatedAt = DateTime.UtcNow;
                    }
                }
                else if(entry.State == EntityState.Modified && entry.Entity is ITimestampedEntity modifiedEntity)
                {
                    modifiedEntity.UpdatedAt = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries<ICuidEntity>())
            {
                if(entry.State == EntityState.Added)
                {
                    if(entry.Entity is ITimestampedEntity timestampedEntity)
                    {
                        timestampedEntity.CreatedAt = DateTime.UtcNow;
                        timestampedEntity.UpdatedAt = DateTime.UtcNow;
                    }
                }
                else if(entry.State == EntityState.Modified && entry.Entity is ITimestampedEntity modifiedEntity)
                {
                    modifiedEntity.UpdatedAt = DateTime.UtcNow;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
