using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PendaftaranUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "gyivt7jiis844jd6b65t8v96");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "q521zlo2j88le15dydvpt4wr");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "xklxqf8q4k6ecg31sxek23e2");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "zk1oxufmf0cr0am8kk4zpnag");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "cz8f46cn8nrs81p0pztnrjvg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fpql8yx02ujgdjdtife1l2ql");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gq3rjm9bcaxhv0065n6oo5ai");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gybwblde5alu33678y6ledbh");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ks0ckh2kfti0gjhcqn9s7ubt");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "letgkkmq2tjr07f7cgt8jijo");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "mbd0rpwywamt5e8d5mjfvkoo");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "o12dqpg1rogpbqnqapxzynzj");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "uz1aphzwhjvx2ljsi8hj0drx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "v10tz371m36yp6to371wr2rq");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "gyivt7jiis844jd6b65t8v96", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(7371), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(7372) },
                    { "q521zlo2j88le15dydvpt4wr", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(9427), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(9428) },
                    { "xklxqf8q4k6ecg31sxek23e2", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(8028), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(8029) },
                    { "zk1oxufmf0cr0am8kk4zpnag", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(8744), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(8745) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "cz8f46cn8nrs81p0pztnrjvg", new DateTime(2024, 6, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9104), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", null, new DateTime(2024, 6, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9091), new DateTime(2024, 12, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9095), new DateTime(2024, 6, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9105), null },
                    { "fpql8yx02ujgdjdtife1l2ql", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(1306), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(1301), new DateTime(2025, 2, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(1303), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(1308), null },
                    { "gq3rjm9bcaxhv0065n6oo5ai", new DateTime(2024, 6, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9895), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", null, new DateTime(2024, 6, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 10, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 6, 24, 9, 38, 2, 875, DateTimeKind.Utc).AddTicks(9897), null },
                    { "gybwblde5alu33678y6ledbh", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(4355), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(4350), new DateTime(2024, 12, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(4352), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(4356), null },
                    { "ks0ckh2kfti0gjhcqn9s7ubt", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5055), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5051), new DateTime(2024, 11, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5052), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5056), null },
                    { "letgkkmq2tjr07f7cgt8jijo", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(572), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(569), new DateTime(2024, 9, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(569), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(574), null },
                    { "mbd0rpwywamt5e8d5mjfvkoo", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5779), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 10, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(5780), null },
                    { "o12dqpg1rogpbqnqapxzynzj", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(3686), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(3682), new DateTime(2025, 1, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(3683), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(3687), null },
                    { "uz1aphzwhjvx2ljsi8hj0drx", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2973), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2969), new DateTime(2024, 10, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2971), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2974), null },
                    { "v10tz371m36yp6to371wr2rq", new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2213), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", null, new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2209), new DateTime(2024, 11, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 6, 24, 9, 38, 2, 876, DateTimeKind.Utc).AddTicks(2214), null }
                });
        }
    }
}
