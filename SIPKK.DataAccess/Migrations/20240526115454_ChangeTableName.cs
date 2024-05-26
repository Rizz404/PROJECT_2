using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_biaya_operational_proyek_id_proyek",
                table: "biaya_operational");

            migrationBuilder.DropPrimaryKey(
                name: "pk_biaya_operational",
                table: "biaya_operational");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "a33oprty31n4raffrrunnyn0");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "knjwmmawdgx07slizavhuche");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ns9erkogg3t9qw4ucc04ozk3");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "y8mkilqamlr6ax42zfm06tpt");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "byysdc6i3zlr0zdyf1p2knx9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "d4vtiwe876fr2sqtwzup9dhg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "f35xro0gnz1fw0uexj7voznc");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fhakjgh0nybe128adkcn5sot");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "lvorlpi7wzivcx3fh2wzmltx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "o67a3zrgfp6t58p47l9gbzqm");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ol6ci2eynapks060nne8bs8b");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qybkilialj9m0ckfb9a9srwt");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "unmzliq976tn867dwnogudsn");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "yr2x7sksx5gcqk2m8kxecbwk");

            migrationBuilder.RenameTable(
                name: "biaya_operational",
                newName: "biaya_operasional");

            migrationBuilder.RenameIndex(
                name: "ix_biaya_operational_id_proyek",
                table: "biaya_operasional",
                newName: "ix_biaya_operasional_id_proyek");

            migrationBuilder.AddPrimaryKey(
                name: "pk_biaya_operasional",
                table: "biaya_operasional",
                column: "id");

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
                name: "fk_biaya_operasional_proyek_id_proyek",
                table: "biaya_operasional",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_biaya_operasional_proyek_id_proyek",
                table: "biaya_operasional");

            migrationBuilder.DropPrimaryKey(
                name: "pk_biaya_operasional",
                table: "biaya_operasional");

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

            migrationBuilder.RenameTable(
                name: "biaya_operasional",
                newName: "biaya_operational");

            migrationBuilder.RenameIndex(
                name: "ix_biaya_operasional_id_proyek",
                table: "biaya_operational",
                newName: "ix_biaya_operational_id_proyek");

            migrationBuilder.AddPrimaryKey(
                name: "pk_biaya_operational",
                table: "biaya_operational",
                column: "id");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "a33oprty31n4raffrrunnyn0", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(9392), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(9393) },
                    { "knjwmmawdgx07slizavhuche", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(7649), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(7650) },
                    { "ns9erkogg3t9qw4ucc04ozk3", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(8620), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(8621) },
                    { "y8mkilqamlr6ax42zfm06tpt", new DateTime(2024, 5, 26, 10, 19, 56, 539, DateTimeKind.Utc).AddTicks(221), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 26, 10, 19, 56, 539, DateTimeKind.Utc).AddTicks(223) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "byysdc6i3zlr0zdyf1p2knx9", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(2635), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 1, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(2636) },
                    { "d4vtiwe876fr2sqtwzup9dhg", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(3928), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(3922), new DateTime(2024, 10, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(3924), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(3929) },
                    { "f35xro0gnz1fw0uexj7voznc", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1051), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1036), new DateTime(2024, 11, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1052) },
                    { "fhakjgh0nybe128adkcn5sot", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1451), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1446), new DateTime(2024, 9, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1448), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1453) },
                    { "lvorlpi7wzivcx3fh2wzmltx", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1896), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1890), new DateTime(2024, 8, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(1897) },
                    { "o67a3zrgfp6t58p47l9gbzqm", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4470), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 9, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4470) },
                    { "ol6ci2eynapks060nne8bs8b", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5220), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5217), new DateTime(2024, 11, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5218), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5221) },
                    { "qybkilialj9m0ckfb9a9srwt", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4806), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4802), new DateTime(2024, 12, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(4807) },
                    { "unmzliq976tn867dwnogudsn", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(6012), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(6007), new DateTime(2024, 9, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(6009), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(6013) },
                    { "yr2x7sksx5gcqk2m8kxecbwk", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5627), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5623), new DateTime(2024, 10, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5624), new DateTime(2024, 5, 26, 10, 19, 56, 538, DateTimeKind.Utc).AddTicks(5628) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_biaya_operational_proyek_id_proyek",
                table: "biaya_operational",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
