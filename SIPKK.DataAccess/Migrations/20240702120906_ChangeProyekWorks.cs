using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeProyekWorks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "verified",
                table: "proyek",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "sudah_selesai",
                table: "proyek",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<bool>(
                name: "verified",
                table: "proyek",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "sudah_selesai",
                table: "proyek",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

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
    }
}
