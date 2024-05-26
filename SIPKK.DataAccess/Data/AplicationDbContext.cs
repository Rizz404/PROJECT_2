using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SIPKK.Models;
using SIPKK.Ultilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Data
{
    public class AplicationDbContext : DbContext
    {
        //harus add reference ke masing masing class library yang berhubungan intinya
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        //! Defaultnya bakal plural hati-hati penamaannya
        //jangan lupa nambahin kalo ada db baru kontol
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Persyaratan> Persyaratan { get; set; }
        public DbSet<Proyek> Proyek { get; set; }
        public DbSet<Mahasiswa> Mahasiswa { get; set; }
        public DbSet<Dosen> Dosen { get; set; }
        public DbSet<ProgramStudi> ProgramStudi { get; set; }
        public DbSet<Konsentrasi> Konsentrasi { get; set; }
        public DbSet<Pendaftaran> Pendaftaran { get; set; }
        public DbSet<BiayaOperational> BiayaOperational { get; set; }
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
