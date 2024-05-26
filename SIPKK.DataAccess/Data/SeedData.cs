using SIPKK.Models;
using System;
using System.Collections.Generic;
using Visus.Cuid;

namespace SIPKK.DataAccess.Data
{
    public static class SeedData
    {
        static readonly Cuid2 cuid = new Cuid2();
        public static List<Proyek> GetProyekData()
        {
            return new List<Proyek>
            {
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Sistem Informasi Akademik",
                    Deskripsi = "Membangun sistem informasi akademik untuk universitas.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(6),
                    Lokasi = "Kampus A",
                    Kuota = 5,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Aplikasi Manajemen Perpustakaan",
                    Deskripsi = "Mengembangkan aplikasi untuk manajemen perpustakaan digital.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(4),
                    Lokasi = "Kampus B",
                    Kuota = 7,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "E-Commerce Platform",
                    Deskripsi = "Membangun platform e-commerce untuk bisnis lokal.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(5),
                    Lokasi = "Kampus C",
                    Kuota = 6,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Sistem Pemesanan Tiket",
                    Deskripsi = "Mengembangkan sistem pemesanan tiket online.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(3),
                    Lokasi = "Kampus D",
                    Kuota = 8,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Aplikasi Mobile Banking",
                    Deskripsi = "Membangun aplikasi mobile untuk layanan perbankan.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(6),
                    Lokasi = "Kampus E",
                    Kuota = 10,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Sistem Informasi Rumah Sakit",
                    Deskripsi = "Mengembangkan sistem informasi untuk rumah sakit.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(7),
                    Lokasi = "Kampus F",
                    Kuota = 9,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Aplikasi Pengelolaan Event",
                    Deskripsi = "Membangun aplikasi untuk manajemen acara dan event.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(4),
                    Lokasi = "Kampus G",
                    Kuota = 5,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Sistem Monitoring Kendaraan",
                    Deskripsi = "Mengembangkan sistem untuk monitoring kendaraan.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(5),
                    Lokasi = "Kampus H",
                    Kuota = 6,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Aplikasi E-Learning",
                    Deskripsi = "Membangun platform e-learning untuk pendidikan online.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(8),
                    Lokasi = "Kampus I",
                    Kuota = 7,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Proyek
                {
                    Id = cuid.ToString(),
                    NamaProyek = "Sistem Manajemen Inventori",
                    Deskripsi = "Mengembangkan sistem manajemen inventori untuk gudang.",
                    TanggalMulai = DateTime.UtcNow,
                    TanggalSelesai = DateTime.UtcNow.AddMonths(4),
                    Lokasi = "Kampus J",
                    Kuota = 8,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
        }

        public static List<ProgramStudi> GetProgramStudiData()
        {
            return new List<ProgramStudi>
            {
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Teknik Informatika",
                    Deskripsi = "Program studi yang berfokus pada teknologi informasi dan komputer.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Sistem Informasi",
                    Deskripsi = "Program studi yang berfokus pada sistem informasi dan manajemennya.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Teknik Elektro",
                    Deskripsi = "Program studi yang berfokus pada teknik elektro dan elektronika.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Teknik Sipil",
                    Deskripsi = "Program studi yang berfokus pada teknik bangunan dan konstruksi.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Manajemen",
                    Deskripsi = "Program studi yang berfokus pada ilmu manajemen dan bisnis.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Akuntansi",
                    Deskripsi = "Program studi yang berfokus pada akuntansi dan keuangan.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Desain Komunikasi Visual",
                    Deskripsi = "Program studi yang berfokus pada desain grafis dan komunikasi visual.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Teknik Mesin",
                    Deskripsi = "Program studi yang berfokus pada teknik mesin dan mekanika.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Teknik Industri",
                    Deskripsi = "Program studi yang berfokus pada teknik industri dan manajemen produksi.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new ProgramStudi
                {
                    Id = cuid.ToString(),
                    Nama = "Ilmu Komputer",
                    Deskripsi = "Program studi yang berfokus pada ilmu komputer dan pemrograman.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
        }
    }
}
