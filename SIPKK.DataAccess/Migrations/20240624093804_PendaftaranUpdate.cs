using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PendaftaranUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "lx721tpsf4lbm2qwhkqn5db2");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "mgo6n83shani3qjhelzi1o7y");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "wk1ctr5cghxm0zbxjlendoy9");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "x3k9xgrpwimfivvxaqb0s1p8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "a5kd3fublmmatvn7ow2spkfg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "clstrlfpnm1sxfeq831vx0h1");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "e65t1xtgtf7l0muzab02f6lx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hwdpax4nmr5qhck61tcboxt3");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "iwe5pote9fpkfcroyms0tl5c");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "k8at32y6tfllfxl586qszu1x");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "szkytatd0ue22j11lj3hivdg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vnrheidwgi409yle8dzq2luz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "x3qdjatibvw6k2fk9x147jxj");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xbpagbg3s9jc4fsiktvbxjwk");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "pendaftaran",
                newName: "bukti_pembayaran");

            migrationBuilder.AddColumn<bool>(
                name: "status_pembayaran",
                table: "pendaftaran",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "status_pembayaran",
                table: "pendaftaran");

            migrationBuilder.RenameColumn(
                name: "bukti_pembayaran",
                table: "pendaftaran",
                newName: "status");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "lx721tpsf4lbm2qwhkqn5db2", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(1624), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(1624) },
                    { "mgo6n83shani3qjhelzi1o7y", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(2103), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(2103) },
                    { "wk1ctr5cghxm0zbxjlendoy9", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(591), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(592) },
                    { "x3k9xgrpwimfivvxaqb0s1p8", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(1059), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 24, 8, 25, 21, 406, DateTimeKind.Utc).AddTicks(1060) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "a5kd3fublmmatvn7ow2spkfg", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5828), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 9, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5827), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5829), null },
                    { "clstrlfpnm1sxfeq831vx0h1", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(7523), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 10, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(7523), null },
                    { "e65t1xtgtf7l0muzab02f6lx", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5309), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5306), new DateTime(2024, 10, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5307), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(5310), null },
                    { "hwdpax4nmr5qhck61tcboxt3", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(6508), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(6504), new DateTime(2025, 2, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(6509), null },
                    { "iwe5pote9fpkfcroyms0tl5c", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8030), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8027), new DateTime(2025, 1, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8030), null },
                    { "k8at32y6tfllfxl586qszu1x", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8647), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8645), new DateTime(2024, 12, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8645), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(8648), null },
                    { "szkytatd0ue22j11lj3hivdg", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(7001), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 11, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(7002), null },
                    { "vnrheidwgi409yle8dzq2luz", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9660), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9658), new DateTime(2024, 10, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9659), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9661), null },
                    { "x3qdjatibvw6k2fk9x147jxj", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9178), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9176), new DateTime(2024, 11, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9176), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(9179), null },
                    { "xbpagbg3s9jc4fsiktvbxjwk", new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(4781), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", null, new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 12, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 6, 24, 8, 25, 21, 405, DateTimeKind.Utc).AddTicks(4783), null }
                });
        }
    }
}
