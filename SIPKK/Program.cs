using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository;
using SIPKK.DataAccess.Repository.IRepository;
using SIPKK.Models;
using SIPKK.Ultilities;
using System;
using Visus.Cuid;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("TestConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
});
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequiredUniqueChars = 0;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 0;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});
builder.Services.AddRazorPages();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEmailSender, EmailSender>();

var app = builder.Build();

// Tambahkan seeding di sini
using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();

    SeedData(context);
}

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Fungsi untuk melakukan seeding data
void SeedData(ApplicationDbContext context)
{
    // Seed ProgramStudi
    if(!context.ProgramStudi.Any())
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

        context.ProgramStudi.AddRange(programStudiEntities);
        context.SaveChanges();

        // Seed Konsentrasi
        var konsentrasiData = new[]
        {
            new { Nama = "Software Engineering", Deskripsi = "Pengembangan perangkat lunak, pengujian, dan pemeliharaan aplikasi.", IdProgramStudi = programStudiIds[0] },
            new { Nama = "Computer Networking", Deskripsi = "Perancangan jaringan komputer, konektivitas, dan administrasi jaringan.", IdProgramStudi = programStudiIds[0] },
            new { Nama = "Business Digital", Deskripsi = "Pengembangan layanan dan proses bisnis berbasis teknologi digital.", IdProgramStudi = programStudiIds[2] },
            new { Nama = "Testing", Deskripsi = "Pengujian fungsional dan kualitas aplikasi untuk proses bisnis digital.", IdProgramStudi = programStudiIds[2] }
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

        context.Konsentrasi.AddRange(konsentrasiEntities);
        context.SaveChanges();
    }

    // Seed Angkatan
    if(!context.Angkatan.Any())
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

        context.Angkatan.AddRange(angkatanEntities);
        context.SaveChanges();
    }

    // Seed Kelas
    if(!context.Kelas.Any())
    {
        var kelasData = new[]
        {
            new { Nama = "2022", Deskripsi = "Kelas untuk mahasiswa angkatan 2022."},
            new { Nama = "2023", Deskripsi = "Kelas untuk mahasiswa angkatan 2023."},
            new { Nama = "2024", Deskripsi = "Kelas untuk mahasiswa angkatan 2024."},
            new { Nama = "2025", Deskripsi = "Kelas untuk mahasiswa angkatan 2025."}
        };

        var kelasEntities = kelasData.Select(data => new Kelas
        {
            Id = new Cuid2().ToString(),
            Nama = data.Nama,
            Deskripsi = data.Deskripsi,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        }).ToList();

        context.Kelas.AddRange(kelasEntities);
        context.SaveChanges();
    }

    // Seed Proyek
    if(!context.Proyek.Any())
    {
        var proyekData = new[]
        {
            new { NamaProyek = "Proyek KKN Pemberdayaan Perempuan", Deskripsi = "Proyek KKN ini bertujuan untuk memberdayakan perempuan di Desa Mandiri melalui pelatihan keterampilan dan pemberian modal usaha.", TipeProyek = Proyek.Tipe.KKN, Kuota = 16, Lokasi = "Garut" },
            new { NamaProyek = "Proyek KKN Pengembangan UMKM", Deskripsi = "Proyek KKN ini bertujuan untuk mengembangkan UMKM di Desa Sejahtera melalui pelatihan dan pemberian modal usaha.", TipeProyek = Proyek.Tipe.KKN, Kuota = 20, Lokasi = "Jakarta" },
            new { NamaProyek = "Proyek KKN Kesehatan Ibu dan Anak", Deskripsi = "Proyek KKN ini bertujuan untuk meningkatkan kesehatan ibu dan anak di Desa Sejahtera melalui program pemeriksaan kesehatan dan edukasi.", TipeProyek = Proyek.Tipe.KKN, Kuota = 8, Lokasi = "Pekalongan" },
            new { NamaProyek = "Proyek KKN Pengolahan Air Bersih", Deskripsi = "Proyek KKN ini bertujuan untuk menyediakan air bersih di Desa Bersih melalui program penyediaan fasilitas air bersih dan edukasi masyarakat.", TipeProyek = Proyek.Tipe.KKN, Kuota = 32, Lokasi = "Papua" },
            new { NamaProyek = "Proyek KKP Literasi Digital", Deskripsi = "Proyek KKP ini bertujuan untuk meningkatkan literasi digital masyarakat di Kota Pintar melalui pelatihan dan seminar.", TipeProyek = Proyek.Tipe.KKP, Kuota = 16, Lokasi = "Garut" },
            new { NamaProyek = "Proyek KKP Pendidikan Anak", Deskripsi = "Proyek KKP ini bertujuan untuk meningkatkan kualitas pendidikan anak di Kota Pintar melalui program bimbingan belajar dan penyediaan fasilitas belajar.", TipeProyek = Proyek.Tipe.KKP, Kuota = 20, Lokasi = "Jakarta" },
            new { NamaProyek = "Proyek KKP Keterampilan Anak Muda", Deskripsi = "Proyek KKP ini bertujuan untuk mengembangkan keterampilan anak muda di Kota Kreatif melalui berbagai pelatihan dan workshop.", TipeProyek = Proyek.Tipe.KKP, Kuota = 8, Lokasi = "Pekalongan" },
            new { NamaProyek = "Proyek KKP Teknologi Pertanian", Deskripsi = "Proyek KKP ini bertujuan untuk mengembangkan teknologi pertanian di Desa Tani melalui program pelatihan dan penerapan teknologi modern.", TipeProyek = Proyek.Tipe.KKP, Kuota = 32, Lokasi = "Papua" }
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

        context.Proyek.AddRange(proyekEntities);
        context.SaveChanges();
    }
}