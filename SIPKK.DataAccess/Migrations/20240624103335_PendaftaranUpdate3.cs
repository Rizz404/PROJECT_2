using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PendaftaranUpdate3 : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "bukti_pembayaran",
                table: "pendaftaran",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "jrls0ca7c88jxm65a16abe6x", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(3591), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(3592) },
                    { "k1i85lhtzd69txjfjjughgj7", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(3118), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(3118) },
                    { "uj7kua57jgviyqi5msnoc0ib", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(4103), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(4104) },
                    { "w83142wbg03sfcf77sjjxxym", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(2523), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(2523) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "bb5pzr816svorcpuoei2cb00", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(623), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", null, new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 12, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(622), new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(624), null },
                    { "e8zthh9k8bjktorqscy401a6", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(146), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", null, new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(144), new DateTime(2025, 1, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(144), new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(147), null },
                    { "hulncyk9f1wnca2z6faks1nf", new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7585), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", null, new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7583), new DateTime(2024, 10, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7583), new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7586), null },
                    { "jhzxn23rpg3jwc75uykqji2l", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1134), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", null, new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 11, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1133), new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1135), null },
                    { "m9gbowzjpy0gw4iolng1ntz3", new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9121), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", null, new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9119), new DateTime(2024, 11, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9122), null },
                    { "mbemjlvbhhnxsy1l7vpilj6w", new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9586), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", null, new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9583), new DateTime(2024, 10, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9584), new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(9586), null },
                    { "oc8aet9lkh6pd70xdrgumkq6", new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8595), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", null, new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8592), new DateTime(2025, 2, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8592), new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8595), null },
                    { "uqa2gf0b6q7vu7pfp2gtcg91", new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8108), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", null, new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 9, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(8108), null },
                    { "wntfawwpbrnbyxkpo5kcwtky", new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1655), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", null, new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1653), new DateTime(2024, 10, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1654), new DateTime(2024, 6, 24, 10, 33, 33, 757, DateTimeKind.Utc).AddTicks(1656), null },
                    { "ylfal3by99x876knd3gikcgy", new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7029), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", null, new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 12, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 6, 24, 10, 33, 33, 756, DateTimeKind.Utc).AddTicks(7030), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "jrls0ca7c88jxm65a16abe6x");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "k1i85lhtzd69txjfjjughgj7");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "uj7kua57jgviyqi5msnoc0ib");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "w83142wbg03sfcf77sjjxxym");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "bb5pzr816svorcpuoei2cb00");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "e8zthh9k8bjktorqscy401a6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hulncyk9f1wnca2z6faks1nf");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "jhzxn23rpg3jwc75uykqji2l");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "m9gbowzjpy0gw4iolng1ntz3");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "mbemjlvbhhnxsy1l7vpilj6w");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "oc8aet9lkh6pd70xdrgumkq6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "uqa2gf0b6q7vu7pfp2gtcg91");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wntfawwpbrnbyxkpo5kcwtky");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ylfal3by99x876knd3gikcgy");

            migrationBuilder.AlterColumn<string>(
                name: "bukti_pembayaran",
                table: "pendaftaran",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
