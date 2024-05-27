using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application_users");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "f1377n4f6vqy7v3b9mkgn26e");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "h10ku1k3jrd1e22bwk4ui9pc");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "p12cl59xx50rgnz3qwz5dm06");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "y127642a8b2a7b882d9ywv7v");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "b14ojdbr9qz0ebewepeehayz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "e4kp19yg8khidc3w2z7sn7q7");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gv21ehh9kwvrnaahyfss6v6s");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "hn6j0whjnarcamiletmpat7h");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "lazft1asqzzwaqni7k6o5n06");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "nszik65c4g5oypq20lsfoijf");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "q147mvgcactla94abp8nkh6l");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s11oojq6sjkfpqfnxrkkntns");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "urc8chpsrvseupzppjwqru9v");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vkw2h2eaunakdu8ndhg754i1");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserTokens",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "AspNetUsers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "discriminator",
                table: "AspNetUsers",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserRoles",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserLogins",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserClaims",
                type: "character varying(50)",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserRoles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "AspNetUserClaims",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.CreateTable(
                name: "application_users",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    access_failed_count = table.Column<int>(type: "integer", nullable: false),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    lockout_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    normalized_email = table.Column<string>(type: "text", nullable: true),
                    normalized_user_name = table.Column<string>(type: "text", nullable: true),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    phone_number_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    security_stamp = table.Column<string>(type: "text", nullable: true),
                    two_factor_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_application_users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "f1377n4f6vqy7v3b9mkgn26e", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5340), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5341) },
                    { "h10ku1k3jrd1e22bwk4ui9pc", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4466), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4467) },
                    { "p12cl59xx50rgnz3qwz5dm06", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4767), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(4768) },
                    { "y127642a8b2a7b882d9ywv7v", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5064), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(5064) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "b14ojdbr9qz0ebewepeehayz", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2839), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2837), new DateTime(2024, 9, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2837), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2839) },
                    { "e4kp19yg8khidc3w2z7sn7q7", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3637), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 10, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3638) },
                    { "gv21ehh9kwvrnaahyfss6v6s", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1752), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1749), new DateTime(2024, 9, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1753) },
                    { "hn6j0whjnarcamiletmpat7h", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2045), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 8, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2045) },
                    { "lazft1asqzzwaqni7k6o5n06", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2327), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 1, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2324), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2328) },
                    { "nszik65c4g5oypq20lsfoijf", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2605), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2603), new DateTime(2024, 10, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(2606) },
                    { "q147mvgcactla94abp8nkh6l", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3893), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 9, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3894) },
                    { "s11oojq6sjkfpqfnxrkkntns", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3365), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3363), new DateTime(2024, 11, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3364), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3366) },
                    { "urc8chpsrvseupzppjwqru9v", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3103), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3100), new DateTime(2024, 12, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3101), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(3103) },
                    { "vkw2h2eaunakdu8ndhg754i1", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1409), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 11, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1402), new DateTime(2024, 5, 27, 12, 36, 49, 188, DateTimeKind.Utc).AddTicks(1410) }
                });
        }
    }
}
