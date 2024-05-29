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
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Persyaratan> Persyaratan { get; set; }
        public DbSet<Proyek> Proyek { get; set; }
        public DbSet<Mahasiswa> Mahasiswa { get; set; }
        public DbSet<Dosen> Dosen { get; set; }
        public DbSet<ProgramStudi> ProgramStudi { get; set; }
        public DbSet<Konsentrasi> Konsentrasi { get; set; }
        public DbSet<Pendaftaran> Pendaftaran { get; set; }
        public DbSet<BiayaOperasional> BiayaOperasional { get; set; }
        public DbSet<Laporan> Laporan { get; set; }
        public DbSet<Test> Test { get; set; }

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

            builder.Entity<Proyek>().HasData(
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Pengembangan Aplikasi Mobile", Deskripsi = "Proyek pengembangan aplikasi mobile untuk bisnis ritel", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(6), Lokasi = "Jakarta", Kuota = 10, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Desain UI/UX Website", Deskripsi = "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(4), Lokasi = "Bandung", Kuota = 8, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Analisis Data Pemasaran", Deskripsi = "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(3), Lokasi = "Surabaya", Kuota = 6, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Pengembangan Game 3D", Deskripsi = "Proyek pengembangan game 3D untuk platform mobile", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(8), Lokasi = "Yogyakarta", Kuota = 12, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Sistem Manajemen Inventaris", Deskripsi = "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(5), Lokasi = "Semarang", Kuota = 8, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Analisis Keamanan Siber", Deskripsi = "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(4), Lokasi = "Medan", Kuota = 6, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Pengembangan Aplikasi Web E-Commerce", Deskripsi = "Proyek pengembangan aplikasi web e-commerce untuk toko online", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(7), Lokasi = "Makassar", Kuota = 10, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Otomatisasi Proses Bisnis", Deskripsi = "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(6), Lokasi = "Palembang", Kuota = 8, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Pengembangan Sistem Manajemen Proyek", Deskripsi = "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(5), Lokasi = "Balikpapan", Kuota = 7, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Proyek { Id = new Cuid2().ToString(), NamaProyek = "Analisis Data Keuangan", Deskripsi = "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", TanggalMulai = DateTime.UtcNow, TanggalSelesai = DateTime.UtcNow.AddMonths(4), Lokasi = "Denpasar", Kuota = 6, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            builder.Entity<ProgramStudi>().HasData(
                new ProgramStudi { Id = new Cuid2().ToString(), Nama = "Teknik Informatika", Deskripsi = "Program studi yang mempelajari ilmu komputer dan teknologi informasi", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ProgramStudi { Id = new Cuid2().ToString(), Nama = "Sistem Informasi", Deskripsi = "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ProgramStudi { Id = new Cuid2().ToString(), Nama = "Manajemen Bisnis", Deskripsi = "Program studi yang mempelajari manajemen dan administrasi bisnis", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ProgramStudi { Id = new Cuid2().ToString(), Nama = "Akuntansi", Deskripsi = "Program studi yang mempelajari prinsip dan praktik akuntansi", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
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
