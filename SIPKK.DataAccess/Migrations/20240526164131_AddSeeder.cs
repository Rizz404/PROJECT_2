using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "czbpnbsct82go2bdqn64j6no");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "fklgw8dmssybz5mf5fsk5kvs");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "tj0b0r11ipr4uwtdyt2uz8z2");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "z8igc94deut80gl73ceeyiqy");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "af2geszux59skw44kmjxgu8c");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "dv4gh9k908qfecxpqxzyf8v0");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "k80qp1b5wt7dwa4vxtovyq2p");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "l856lksnkka654tv2a3sd17r");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "pl5vz4ftcxeyh0loe7fky6ae");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qzj2dwcon3bgd3c5i3y7o8ng");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "tosul4ox4z960nrunzo8ljph");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "w1377dbn20vyyxbl8itvs5h9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "yo4dsq2v5ag3y5oe41nzn0ld");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "zrnxrvjypob9vy53fz9k4ho0");

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "dosen",
                type: "character varying(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.InsertData(
                table: "konsentrasi",
                columns: new[] { "id", "created_at", "deskripsi", "id_program_studi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "iqzt4cfpywz2pdxehatkulux", new DateTime(2024, 5, 26, 16, 41, 27, 513, DateTimeKind.Utc).AddTicks(35), "Konsentrasi yang berfokus pada sistem informasi dalam bidang akuntansi.", "z8igc94deut80gl73ceeyiqy", "Sistem Informasi Akuntansi", new DateTime(2024, 5, 26, 16, 41, 27, 513, DateTimeKind.Utc).AddTicks(36) },
                    { "o130yn7vhh9ta6jv0wq52s9d", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(8663), "Konsentrasi yang berfokus pada pengembangan dan pemeliharaan perangkat lunak.", "tj0b0r11ipr4uwtdyt2uz8z2", "Rekayasa Perangkat Lunak", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(8664) },
                    { "ynnz19zkvchm1ea5gna204bk", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(9342), "Konsentrasi yang berfokus pada teknologi multimedia dan jaringan komputer.", "tj0b0r11ipr4uwtdyt2uz8z2", "Multimedia dan Jaringan", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(9343) }
                });

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "hdao7uokuouf29pexpz8qly3", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(7838), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(7839) },
                    { "k12v4h3gb3uronyzujlywyyx", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(6247), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(6248) },
                    { "rbvr538fajhr8zv1fyxpqe8n", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(6967), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(6968) },
                    { "w14mbimy6odjcaix5kycg674", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(5540), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(5542) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "cbjvz2zn8tnv8vw67sq3zelz", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(838), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(825), new DateTime(2024, 11, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(829), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(839) },
                    { "hmrofobbjg6aqbl6zi959r2o", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1708), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 8, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1709) },
                    { "ixyd30bdgmctvhmf273julx2", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1241), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 9, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(1242) },
                    { "k2sucedowojgf3fysuois86i", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2037), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2031), new DateTime(2025, 1, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2034), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2038) },
                    { "kl9jt6sp67niy0xtahfxgoul", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(4297), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(4294), new DateTime(2024, 9, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(4295), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(4297) },
                    { "mk6yfz903hnlfbv6qkyaatnk", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2836), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2833), new DateTime(2024, 9, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2834), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2837) },
                    { "qmywne21dx64z8s2evrba0of", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3219), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 12, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3220) },
                    { "u11l5d3qi25h5qnnc93cv8vb", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3613), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 11, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3611), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3614) },
                    { "y2mhuhatwzr4b1mwz0dyhvqf", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3926), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 10, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3924), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(3926) },
                    { "yft9d06n3i1klnz9kk8yla2l", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2455), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2451), new DateTime(2024, 10, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 5, 26, 16, 41, 27, 512, DateTimeKind.Utc).AddTicks(2456) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen");

            migrationBuilder.DeleteData(
                table: "konsentrasi",
                keyColumn: "id",
                keyValue: "iqzt4cfpywz2pdxehatkulux");

            migrationBuilder.DeleteData(
                table: "konsentrasi",
                keyColumn: "id",
                keyValue: "o130yn7vhh9ta6jv0wq52s9d");

            migrationBuilder.DeleteData(
                table: "konsentrasi",
                keyColumn: "id",
                keyValue: "ynnz19zkvchm1ea5gna204bk");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "hdao7uokuouf29pexpz8qly3");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "k12v4h3gb3uronyzujlywyyx");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "rbvr538fajhr8zv1fyxpqe8n");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "w14mbimy6odjcaix5kycg674");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "cbjvz2zn8tnv8vw67sq3zelz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hmrofobbjg6aqbl6zi959r2o");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ixyd30bdgmctvhmf273julx2");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "k2sucedowojgf3fysuois86i");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "kl9jt6sp67niy0xtahfxgoul");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "mk6yfz903hnlfbv6qkyaatnk");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qmywne21dx64z8s2evrba0of");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u11l5d3qi25h5qnnc93cv8vb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "y2mhuhatwzr4b1mwz0dyhvqf");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "yft9d06n3i1klnz9kk8yla2l");

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "dosen",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "czbpnbsct82go2bdqn64j6no", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8362), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8362) },
                    { "fklgw8dmssybz5mf5fsk5kvs", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8913), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8914) },
                    { "tj0b0r11ipr4uwtdyt2uz8z2", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7232), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7233) },
                    { "z8igc94deut80gl73ceeyiqy", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7811), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7811) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "af2geszux59skw44kmjxgu8c", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3975), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3972), new DateTime(2024, 9, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3973), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3975) },
                    { "dv4gh9k908qfecxpqxzyf8v0", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6375), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6373), new DateTime(2024, 9, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6373), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6376) },
                    { "k80qp1b5wt7dwa4vxtovyq2p", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5380), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 12, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5380) },
                    { "l856lksnkka654tv2a3sd17r", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6085), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 10, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6086) },
                    { "pl5vz4ftcxeyh0loe7fky6ae", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3708), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3694), new DateTime(2024, 11, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3697), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3709) },
                    { "qzj2dwcon3bgd3c5i3y7o8ng", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5707), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 11, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5707) },
                    { "tosul4ox4z960nrunzo8ljph", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4867), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4865), new DateTime(2024, 10, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4866), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4868) },
                    { "w1377dbn20vyyxbl8itvs5h9", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4280), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 8, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4280) },
                    { "yo4dsq2v5ag3y5oe41nzn0ld", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4575), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 1, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4576) },
                    { "zrnxrvjypob9vy53fz9k4ho0", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5137), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5134), new DateTime(2024, 9, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5135), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5137) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
