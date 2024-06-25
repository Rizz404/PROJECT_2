using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeBuktiPembayaranIntoNullConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "gkp433kqelupid76db8lcj9w");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "lxxt0stb4wjegui0makzol2l");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "u11rv4deedvosz8ycn49hj7i");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "y11qnqjzl16uxe7iorxguchq");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "b14csntgmrog1wf3ynmmt76z");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hzo98umxl8c9y5vrdvhu2rby");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "it0wqqi6ybh7v0rf63f0fnk4");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ms0a5zdpd7swqb2jbouwimzz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "o6a0byujek57v4tk9sfj1blr");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r94la88jeqd5mqg3a2qywi4z");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "rmz6bsduh3bribjilgirdety");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "scauadaat68qam3m4wcf16fs");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "twdciq2mw1f2pj6x1iohc7pu");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vnym4yoau08ehd1iw1m30647");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "bu3y4wmq2tz2nelh613zyhl5", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(7507), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(7507) },
                    { "g64k7vzox06htr1tykcvru6r", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(8263), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(8264) },
                    { "jqlzggwzp42mbxvxwmu8myxc", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(7859), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(7860) },
                    { "m503eabgbe1e8a09u2pc0qeg", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(8618), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(8618) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "b598i89xlvq9l5enzor1ujko", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4541), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 2, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4541), null },
                    { "bdq4ynha8rv86d9qluyxue1h", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5714), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5711), new DateTime(2025, 1, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5712), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5715), null },
                    { "ke28249t8vr6g0dy7xzjgt5p", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3762), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3759), new DateTime(2024, 10, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3760), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3763), null },
                    { "n28vbkjl7oxp53v2bt6efen5", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5311), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 10, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(5312), null },
                    { "o4w7yqzxfq2tnrj5o09lgwis", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6472), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6469), new DateTime(2024, 11, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6470), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6473), null },
                    { "q3zr2vnp2byboft8sk5uoa30", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4908), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4906), new DateTime(2024, 11, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4906), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4909), null },
                    { "s6b1udkfk18cca5926te1yu5", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6826), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6823), new DateTime(2024, 10, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6824), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6826), null },
                    { "sgb4h5jpacmawymcmto3nrj2", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6099), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6096), new DateTime(2024, 12, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6097), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(6100), null },
                    { "wm0znk59u781htfido3v9jby", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4137), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4134), new DateTime(2024, 9, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4135), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(4137), null },
                    { "xngfycxbex5og4zq2d9ky127", new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3361), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", null, new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3350), new DateTime(2024, 12, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3354), new DateTime(2024, 6, 25, 2, 30, 32, 365, DateTimeKind.Utc).AddTicks(3363), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "bu3y4wmq2tz2nelh613zyhl5");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "g64k7vzox06htr1tykcvru6r");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "jqlzggwzp42mbxvxwmu8myxc");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "m503eabgbe1e8a09u2pc0qeg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "b598i89xlvq9l5enzor1ujko");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "bdq4ynha8rv86d9qluyxue1h");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ke28249t8vr6g0dy7xzjgt5p");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "n28vbkjl7oxp53v2bt6efen5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "o4w7yqzxfq2tnrj5o09lgwis");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "q3zr2vnp2byboft8sk5uoa30");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s6b1udkfk18cca5926te1yu5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "sgb4h5jpacmawymcmto3nrj2");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wm0znk59u781htfido3v9jby");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xngfycxbex5og4zq2d9ky127");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "gkp433kqelupid76db8lcj9w", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(8657), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(8658) },
                    { "lxxt0stb4wjegui0makzol2l", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(6980), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(6980) },
                    { "u11rv4deedvosz8ycn49hj7i", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(7582), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(7583) },
                    { "y11qnqjzl16uxe7iorxguchq", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(8097), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(8098) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "b14csntgmrog1wf3ynmmt76z", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4801), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 12, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4801), null },
                    { "hzo98umxl8c9y5vrdvhu2rby", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(1484), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 10, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(1484), null },
                    { "it0wqqi6ybh7v0rf63f0fnk4", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2061), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2058), new DateTime(2024, 9, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2060), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2062), null },
                    { "ms0a5zdpd7swqb2jbouwimzz", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4276), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4273), new DateTime(2025, 1, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4274), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(4276), null },
                    { "o6a0byujek57v4tk9sfj1blr", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3687), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3685), new DateTime(2024, 10, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3685), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3687), null },
                    { "r94la88jeqd5mqg3a2qywi4z", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2590), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2587), new DateTime(2025, 2, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(2591), null },
                    { "rmz6bsduh3bribjilgirdety", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3140), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 11, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3139), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(3141), null },
                    { "scauadaat68qam3m4wcf16fs", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(6009), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(6006), new DateTime(2024, 10, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(6007), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(6009), null },
                    { "twdciq2mw1f2pj6x1iohc7pu", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(5370), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(5368), new DateTime(2024, 11, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(5368), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(5371), null },
                    { "vnym4yoau08ehd1iw1m30647", new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(935), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", null, new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(926), new DateTime(2024, 12, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(928), new DateTime(2024, 6, 24, 9, 46, 18, 135, DateTimeKind.Utc).AddTicks(937), null }
                });
        }
    }
}
