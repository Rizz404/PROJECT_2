using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addfileforproyekandlaporan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "laa8a2o8f8ftk2eyxiz0i1g0");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "lirzmjy9ncb43uhlr32zt136");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "tjn9x7ggv6yaassyzsfurc80");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "xtp52d8daii686rrdp9vn4mr");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "bebbsi7nuntawyz7briw3mej");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "c13untxobtks4xrk87eqauko");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "d9pn2vpw9e3ryy9eboycgm3y");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fyzcw22zdiwafkbsmz1eumno");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "h314hmnxxjco2l5be4qc6hhq");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ng3rdzwnhel3ficjbjogwuai");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "q985ll02bo80ijpcssp2mu7t");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qngnmnhamh0hwl5xv5tnb5p0");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "sannt2z90yargmu187o7xd87");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u7tfds31ibhuolv0h6ykom6f");

            migrationBuilder.AddColumn<string>(
                name: "foto_proyek",
                table: "proyek",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "file_laporan",
                table: "laporan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "foto_laporan",
                table: "laporan",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "j9xn7hio7fc5pytxjzcveqow", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(8118), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(8118) },
                    { "rynv8ch7bfyx6ynfcybqdzl0", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(8645), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(8646) },
                    { "s7l8kd11mxml7yurdfhkb87x", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(9205), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(9206) },
                    { "u128ewth7y7upp602ngog0th", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(9713), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(9714) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "ab1w3w3r8tas3ttyh2giy1xb", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6575), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6572), new DateTime(2024, 12, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6573), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6575) },
                    { "d1vwu13aw27oprew47equrf9", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5469), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5466), new DateTime(2025, 2, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5467), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5470) },
                    { "fusyrvoa95b12z4teeon0gfe", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6037), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6035), new DateTime(2024, 10, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6038) },
                    { "jbdxnw1nyybpb6if45mt963j", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4905), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4903), new DateTime(2024, 10, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4903), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4905) },
                    { "jr5w1nto1suflbpsplr1xgay", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6328), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6326), new DateTime(2025, 1, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6329) },
                    { "oldszmgkxf9l3u4r1qdp947d", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5754), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 11, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5755) },
                    { "qgvx6rnictbw4xwi5cjxt9z8", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6863), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6861), new DateTime(2024, 11, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(6864) },
                    { "v11o37abmc3bz4dyxylymmuo", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4578), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 12, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(4579) },
                    { "y9enuuw0q0ht3jenoisy0t39", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(7132), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 10, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(7130), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(7132) },
                    { "z695dhhemrfd3pk0sn5b8qr0", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5220), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5216), new DateTime(2024, 9, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5218), new DateTime(2024, 6, 14, 1, 43, 11, 865, DateTimeKind.Utc).AddTicks(5221) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "j9xn7hio7fc5pytxjzcveqow");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "rynv8ch7bfyx6ynfcybqdzl0");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "s7l8kd11mxml7yurdfhkb87x");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "u128ewth7y7upp602ngog0th");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ab1w3w3r8tas3ttyh2giy1xb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "d1vwu13aw27oprew47equrf9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fusyrvoa95b12z4teeon0gfe");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "jbdxnw1nyybpb6if45mt963j");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "jr5w1nto1suflbpsplr1xgay");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "oldszmgkxf9l3u4r1qdp947d");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qgvx6rnictbw4xwi5cjxt9z8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "v11o37abmc3bz4dyxylymmuo");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "y9enuuw0q0ht3jenoisy0t39");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "z695dhhemrfd3pk0sn5b8qr0");

            migrationBuilder.DropColumn(
                name: "foto_proyek",
                table: "proyek");

            migrationBuilder.DropColumn(
                name: "file_laporan",
                table: "laporan");

            migrationBuilder.DropColumn(
                name: "foto_laporan",
                table: "laporan");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "laa8a2o8f8ftk2eyxiz0i1g0", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(7693), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(7694) },
                    { "lirzmjy9ncb43uhlr32zt136", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6144), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6146) },
                    { "tjn9x7ggv6yaassyzsfurc80", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(8489), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(8490) },
                    { "xtp52d8daii686rrdp9vn4mr", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6840), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6841) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "bebbsi7nuntawyz7briw3mej", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1829), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 10, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1830) },
                    { "c13untxobtks4xrk87eqauko", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4206), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4202), new DateTime(2024, 12, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4203), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4206) },
                    { "d9pn2vpw9e3ryy9eboycgm3y", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4537), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 11, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4538) },
                    { "fyzcw22zdiwafkbsmz1eumno", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4930), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 10, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4928), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4931) },
                    { "h314hmnxxjco2l5be4qc6hhq", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2652), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 2, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2649), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2653) },
                    { "ng3rdzwnhel3ficjbjogwuai", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3407), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3404), new DateTime(2024, 10, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3408) },
                    { "q985ll02bo80ijpcssp2mu7t", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3801), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 1, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3802) },
                    { "qngnmnhamh0hwl5xv5tnb5p0", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2990), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 11, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2991) },
                    { "sannt2z90yargmu187o7xd87", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1396), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1381), new DateTime(2024, 12, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1396) },
                    { "u7tfds31ibhuolv0h6ykom6f", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2205), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 9, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2206) }
                });
        }
    }
}
