using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "iiqo9ov7hv5encra8qytfo6o");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "nxmcs7geyl5p53ckkf9ydakx");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "q8t3d2ke4m5f4x7ao8j989v0");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ya7bxifiyv6dem6u53p6fv9t");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "cyb9u3noccu9k4iju7p2cwng");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gw0iqb8jyc02ikgcwy3qfw8p");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "l101w2coqcv1b7bewjn7ykt8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "lb9cicnhdp1b07v1ko4dccgr");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "magk1v82wpyd2nacz9vm7tu9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ox59qsga66ohvqevmvwydroh");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "p11grajgke8of3a1ad7iu3el");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "v2cw99pardmt0w7x9oz197mp");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "z12rs6zy7vpmdg4dya7zsofh");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "z2uar9vubao6x7mlwx3v14cg");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "login_provider",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "provider_key",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "login_provider",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "ax8awnnm508ln8g9bf6z3vsy", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(802), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(802) },
                    { "kkzz5kjf3wiyi55ld2w92prb", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(1321), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(1322) },
                    { "xj2b1v5yld1wiqymu0uwor5o", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(1047), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(1047) },
                    { "z4ozsqd2efmve5mt2gqz5l3f", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(520), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 27, 14, 50, 44, 534, DateTimeKind.Utc).AddTicks(522) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "bnblthyoqvccycga2k5e96my", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8690), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8686), new DateTime(2024, 9, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8688), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8690) },
                    { "dbrtvbll9zat2liiuqii5c1k", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9220), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9218), new DateTime(2024, 11, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9219), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9221) },
                    { "dvvmrzwh7aps03kxtnwidcos", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8405), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 10, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8406) },
                    { "i12006s4d4foermixk5kentz", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8982), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 12, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8981), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8983) },
                    { "ijddf9sjxzb8udvekkz4v0t8", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7829), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 8, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7827), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7829) },
                    { "j9dt84ujj4p1u2sjlk0kbwpv", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7255), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 11, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7248), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7256) },
                    { "jvxni2xas252qh55s3xfr5kk", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9809), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9807), new DateTime(2024, 9, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9808), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9810) },
                    { "l1h2113hm3o3zn86ws5vumdr", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7578), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7574), new DateTime(2024, 9, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7575), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(7578) },
                    { "p14nzl7dplylgszusr9k2ntb", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9500), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9498), new DateTime(2024, 10, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9499), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(9501) },
                    { "rgrfyhakb40duxbd1mrmvvmj", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8120), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 1, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8117), new DateTime(2024, 5, 27, 14, 50, 44, 533, DateTimeKind.Utc).AddTicks(8120) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ax8awnnm508ln8g9bf6z3vsy");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "kkzz5kjf3wiyi55ld2w92prb");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "xj2b1v5yld1wiqymu0uwor5o");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "z4ozsqd2efmve5mt2gqz5l3f");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "bnblthyoqvccycga2k5e96my");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "dbrtvbll9zat2liiuqii5c1k");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "dvvmrzwh7aps03kxtnwidcos");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "i12006s4d4foermixk5kentz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ijddf9sjxzb8udvekkz4v0t8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "j9dt84ujj4p1u2sjlk0kbwpv");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "jvxni2xas252qh55s3xfr5kk");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "l1h2113hm3o3zn86ws5vumdr");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "p14nzl7dplylgszusr9k2ntb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "rgrfyhakb40duxbd1mrmvvmj");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "login_provider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "provider_key",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "login_provider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "iiqo9ov7hv5encra8qytfo6o", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(8714), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(8715) },
                    { "nxmcs7geyl5p53ckkf9ydakx", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(7654), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(7655) },
                    { "q8t3d2ke4m5f4x7ao8j989v0", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(8352), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(8353) },
                    { "ya7bxifiyv6dem6u53p6fv9t", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(7968), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(7969) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "cyb9u3noccu9k4iju7p2cwng", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4693), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4686), new DateTime(2024, 11, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4688), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4694) },
                    { "gw0iqb8jyc02ikgcwy3qfw8p", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5195), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5192), new DateTime(2024, 10, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5196) },
                    { "l101w2coqcv1b7bewjn7ykt8", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4150), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 12, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(4151) },
                    { "lb9cicnhdp1b07v1ko4dccgr", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2169), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2165), new DateTime(2024, 9, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2166), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2170) },
                    { "magk1v82wpyd2nacz9vm7tu9", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3010), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3005), new DateTime(2025, 1, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3006), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3011) },
                    { "ox59qsga66ohvqevmvwydroh", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(1835), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(1817), new DateTime(2024, 11, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(1823), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(1836) },
                    { "p11grajgke8of3a1ad7iu3el", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3809), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 9, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3810) },
                    { "v2cw99pardmt0w7x9oz197mp", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2611), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 8, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(2612) },
                    { "z12rs6zy7vpmdg4dya7zsofh", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5638), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 9, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5635), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(5638) },
                    { "z2uar9vubao6x7mlwx3v14cg", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3416), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 10, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3413), new DateTime(2024, 5, 27, 12, 58, 8, 68, DateTimeKind.Utc).AddTicks(3417) }
                });
        }
    }
}
