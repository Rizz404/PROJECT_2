using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "klfqccrp7yuvnh0d344qy9dc");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "r73zspehmi74r71c4iztluz5");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "u5v610mbbw5c435evtu77bor");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "z13ymogdk61lo6r777ar2945");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "pdndbo0u78ao56t9xj0en61g");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qbg2dcix2k6v90m26jiftsfm");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r13pbwyxy0weg3kiino8bnxu");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "rrgta68zxqxrit1xeyl4z3vb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s11dvwmcszzaysrt5md1qnsz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "sek67pendj81w75p5r0nll78");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "v14iam7xw7etfgt37ez2g8cg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vohobmngojfyegdqvdm2o1ef");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wiwsvsyoz4q6bz2quihj4nty");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "zsl3lei2u152aqwucdtwfls8");

            migrationBuilder.CreateTable(
                name: "application_users",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_name = table.Column<string>(type: "text", nullable: true),
                    normalized_user_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    normalized_email = table.Column<string>(type: "text", nullable: true),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    security_stamp = table.Column<string>(type: "text", nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    phone_number_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    two_factor_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    lockout_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    access_failed_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_application_users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "f1377n4f6vqy7v3b9mkgn26e", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5340), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5341) },
                    { "h10ku1k3jrd1e22bwk4ui9pc", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4466), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4467) },
                    { "p12cl59xx50rgnz3qwz5dm06", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4767), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4768) },
                    { "y127642a8b2a7b882d9ywv7v", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5064), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5064) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "b14ojdbr9qz0ebewepeehayz", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2839), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2837), new DateTime(2024, 9, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2837), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2839) },
                    { "e4kp19yg8khidc3w2z7sn7q7", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3637), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 10, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3638) },
                    { "gv21ehh9kwvrnaahyfss6v6s", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1752), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1749), new DateTime(2024, 9, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1753) },
                    { "hn6j0whjnarcamiletmpat7h", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2045), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 8, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2045) },
                    { "lazft1asqzzwaqni7k6o5n06", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2327), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 1, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2324), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2328) },
                    { "nszik65c4g5oypq20lsfoijf", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2605), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2603), new DateTime(2024, 10, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2606) },
                    { "q147mvgcactla94abp8nkh6l", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3893), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 9, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3894) },
                    { "s11oojq6sjkfpqfnxrkkntns", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3365), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3363), new DateTime(2024, 11, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3364), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3366) },
                    { "urc8chpsrvseupzppjwqru9v", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3103), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3100), new DateTime(2024, 12, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3101), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3103) },
                    { "vkw2h2eaunakdu8ndhg754i1", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1409), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 11, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1402), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1410) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application_users");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "f1377n4f6vqy7v3b9mkgn26e");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "h10ku1k3jrd1e22bwk4ui9pc");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "p12cl59xx50rgnz3qwz5dm06");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "y127642a8b2a7b882d9ywv7v");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "b14ojdbr9qz0ebewepeehayz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "e4kp19yg8khidc3w2z7sn7q7");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gv21ehh9kwvrnaahyfss6v6s");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hn6j0whjnarcamiletmpat7h");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "lazft1asqzzwaqni7k6o5n06");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "nszik65c4g5oypq20lsfoijf");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "q147mvgcactla94abp8nkh6l");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s11oojq6sjkfpqfnxrkkntns");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "urc8chpsrvseupzppjwqru9v");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vkw2h2eaunakdu8ndhg754i1");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "klfqccrp7yuvnh0d344qy9dc", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6456), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6457) },
                    { "r73zspehmi74r71c4iztluz5", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6235), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6235) },
                    { "u5v610mbbw5c435evtu77bor", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5963), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5964) },
                    { "z13ymogdk61lo6r777ar2945", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6724), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6724) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "pdndbo0u78ao56t9xj0en61g", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4233), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4231), new DateTime(2024, 9, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4232), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4234) },
                    { "qbg2dcix2k6v90m26jiftsfm", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4502), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 12, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4503) },
                    { "r13pbwyxy0weg3kiino8bnxu", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4980), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 10, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4978), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4980) },
                    { "rrgta68zxqxrit1xeyl4z3vb", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2890), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2881), new DateTime(2024, 11, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2884), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2891) },
                    { "s11dvwmcszzaysrt5md1qnsz", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3186), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 9, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3187) },
                    { "sek67pendj81w75p5r0nll78", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3416), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3414), new DateTime(2024, 8, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3417) },
                    { "v14iam7xw7etfgt37ez2g8cg", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3960), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3958), new DateTime(2024, 10, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3958), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3960) },
                    { "vohobmngojfyegdqvdm2o1ef", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3690), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3686), new DateTime(2025, 1, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3690) },
                    { "wiwsvsyoz4q6bz2quihj4nty", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5291), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5289), new DateTime(2024, 9, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5290), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5292) },
                    { "zsl3lei2u152aqwucdtwfls8", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4727), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 11, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4727) }
                });
        }
    }
}
