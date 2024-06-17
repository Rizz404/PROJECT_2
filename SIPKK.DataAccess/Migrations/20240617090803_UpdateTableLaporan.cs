using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableLaporan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "id_mahasiswa",
                table: "laporan",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "azo9cvdvlirbpy6bnglmzj7b", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8310), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8312) },
                    { "evdrkfnqro8en5iclaecksot", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8928), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8929) },
                    { "f5bev60s6722qi432liuilkl", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(9491), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(9493) },
                    { "j12rshdujovn6nx8xk88i19t", new DateTime(2024, 6, 17, 9, 7, 58, 910, DateTimeKind.Utc).AddTicks(89), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 17, 9, 7, 58, 910, DateTimeKind.Utc).AddTicks(90) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "apfvcrvxfuigzch8enfv54i5", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4890), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 9, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4887), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4891) },
                    { "e22myucr3nxudwbu87etxt5q", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6468), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6466), new DateTime(2024, 12, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6466), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6469) },
                    { "fiv70o00smrilhixkk82wkgb", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5273), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5269), new DateTime(2025, 2, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5270), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5274) },
                    { "fq11wrhjbsft2f9zbxmcc19i", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3939), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3927), new DateTime(2024, 12, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3931), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3941) },
                    { "gkpud0yno7fw673yexzed3rm", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7182), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 10, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7182) },
                    { "ttv2jmp4h6rce0f5sy64su3w", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5858), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5855), new DateTime(2024, 10, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5859) },
                    { "u358dhu07aa5293yihyfqskx", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4378), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 10, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4374), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4380) },
                    { "wb64ef4q0pu24agx3r8yudc6", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5591), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5589), new DateTime(2024, 11, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5592) },
                    { "y6k6tynjs4togcxtxrux6hve", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6837), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 11, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6837) },
                    { "yailwv3iyatztk5yezuhxbmn", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6172), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6170), new DateTime(2025, 1, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6171), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6173) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan",
                column: "id_mahasiswa");

            migrationBuilder.AddForeignKey(
                name: "fk_laporan_mahasiswa_id_mahasiswa",
                table: "laporan",
                column: "id_mahasiswa",
                principalTable: "mahasiswa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_laporan_mahasiswa_id_mahasiswa",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "azo9cvdvlirbpy6bnglmzj7b");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "evdrkfnqro8en5iclaecksot");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "f5bev60s6722qi432liuilkl");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "j12rshdujovn6nx8xk88i19t");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "apfvcrvxfuigzch8enfv54i5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "e22myucr3nxudwbu87etxt5q");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fiv70o00smrilhixkk82wkgb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fq11wrhjbsft2f9zbxmcc19i");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gkpud0yno7fw673yexzed3rm");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ttv2jmp4h6rce0f5sy64su3w");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u358dhu07aa5293yihyfqskx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wb64ef4q0pu24agx3r8yudc6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "y6k6tynjs4togcxtxrux6hve");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "yailwv3iyatztk5yezuhxbmn");

            migrationBuilder.DropColumn(
                name: "id_mahasiswa",
                table: "laporan");

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
    }
}
