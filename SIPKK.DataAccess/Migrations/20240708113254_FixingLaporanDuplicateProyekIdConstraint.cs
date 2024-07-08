using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixingLaporanDuplicateProyekIdConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_laporan_id_proyek",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_biaya_operasional_id_proyek",
                table: "biaya_operasional");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "dkx2ebb52k8u1frcumh0lg8z");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "h14en52s20am3n0j8qfl8rvg");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "o117trvfk4k9u2v6pu2ter92");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "t11socm9vhyvy2v0j8csiaky");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "bwdewgyxcr1knmxg2ynq6st6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "c11defmk0z3k4mfambro4a52");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hunm7qd8tzjvj88c7nfzw5lx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ng8gsmjky66jv21775b0gqfe");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "q7z5aojk6nsjkkbjjdzw2pv2");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qs2gckg4ui8d3wfp7g8yezsk");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "raury4x4z6h1gfxxfuaegih1");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wxdvime89rfqe3qimyk765xx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ynlvk1v310zu2vu8jjxatgbr");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "z12hosxfj9su9tmwca7zm4x9");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "kx5tyv1pwviukeiss489slcl", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9454), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9455) },
                    { "p7qsf9uvi769euihj8uuuw7g", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(392), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(393) },
                    { "ptksja2l2m8l3l8k8uwvuolw", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(112), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(113) },
                    { "r122jeiuizwufsef6jigw68z", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9796), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9797) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "amsvdevco4e24mwbrn9nnfr8", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6183), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 1, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6176), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6184), false },
                    { "au0ngvltvhkpmocb4id333qk", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7793), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 11, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7794), false },
                    { "emfdisll88gq1d3cjlmcayt3", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7078), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7076), new DateTime(2025, 3, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7076), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7079), false },
                    { "ettelgsggjcjzbei6br09vv9", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8675), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 12, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8676), false },
                    { "i53k2o6oagrt4lnfv6erlkn9", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9018), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9015), new DateTime(2024, 11, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9018), false },
                    { "rday0y3zbcxyofplk4exv464", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6482), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 11, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6483), false },
                    { "s12qhsxlf7ms62u8fc82wfhc", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8400), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 1, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8401), false },
                    { "s8ajrjewqdqdeixxmb59kb08", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6802), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 10, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6803), false },
                    { "vcvmyf2oxw4sk3aybaby6x0z", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8080), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 2, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8078), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8080), false },
                    { "xenr3ryty8114gow6gn1e775", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7472), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 12, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7472), false }
                });

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan",
                column: "id_mahasiswa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_proyek",
                table: "laporan",
                column: "id_proyek");

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operasional_id_proyek",
                table: "biaya_operasional",
                column: "id_proyek");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_laporan_id_proyek",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_biaya_operasional_id_proyek",
                table: "biaya_operasional");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "kx5tyv1pwviukeiss489slcl");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "p7qsf9uvi769euihj8uuuw7g");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ptksja2l2m8l3l8k8uwvuolw");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "r122jeiuizwufsef6jigw68z");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "amsvdevco4e24mwbrn9nnfr8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "au0ngvltvhkpmocb4id333qk");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "emfdisll88gq1d3cjlmcayt3");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ettelgsggjcjzbei6br09vv9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "i53k2o6oagrt4lnfv6erlkn9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "rday0y3zbcxyofplk4exv464");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s12qhsxlf7ms62u8fc82wfhc");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s8ajrjewqdqdeixxmb59kb08");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vcvmyf2oxw4sk3aybaby6x0z");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xenr3ryty8114gow6gn1e775");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "dkx2ebb52k8u1frcumh0lg8z", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(2992), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(2993) },
                    { "h14en52s20am3n0j8qfl8rvg", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(1490), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(1490) },
                    { "o117trvfk4k9u2v6pu2ter92", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(2208), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(2209) },
                    { "t11socm9vhyvy2v0j8csiaky", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(3671), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 7, 2, 12, 9, 2, 44, DateTimeKind.Utc).AddTicks(3672) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "bwdewgyxcr1knmxg2ynq6st6", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4962), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4956), new DateTime(2025, 3, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4959), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4963), false },
                    { "c11defmk0z3k4mfambro4a52", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(6580), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(6576), new DateTime(2024, 11, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(6577), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(6581), false },
                    { "hunm7qd8tzjvj88c7nfzw5lx", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(2514), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(2501), new DateTime(2025, 1, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(2505), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(2515), false },
                    { "ng8gsmjky66jv21775b0gqfe", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(7292), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(7287), new DateTime(2025, 2, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(7289), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(7293), false },
                    { "q7z5aojk6nsjkkbjjdzw2pv2", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8770), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8766), new DateTime(2024, 12, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8767), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8770), false },
                    { "qs2gckg4ui8d3wfp7g8yezsk", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(3344), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(3338), new DateTime(2024, 11, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(3340), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(3346), false },
                    { "raury4x4z6h1gfxxfuaegih1", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(5797), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 12, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(5794), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(5808), false },
                    { "wxdvime89rfqe3qimyk765xx", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(9631), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(9628), new DateTime(2024, 11, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(9629), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(9632), false },
                    { "ynlvk1v310zu2vu8jjxatgbr", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4087), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 10, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4084), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(4088), false },
                    { "z12hosxfj9su9tmwca7zm4x9", new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8081), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", false, new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 1, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8078), new DateTime(2024, 7, 2, 12, 9, 2, 43, DateTimeKind.Utc).AddTicks(8081), false }
                });

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan",
                column: "id_mahasiswa");

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_proyek",
                table: "laporan",
                column: "id_proyek",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operasional_id_proyek",
                table: "biaya_operasional",
                column: "id_proyek",
                unique: true);
        }
    }
}
