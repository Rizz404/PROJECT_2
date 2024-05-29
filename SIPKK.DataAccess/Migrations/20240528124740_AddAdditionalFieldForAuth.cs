using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalFieldForAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek",
                table: "mahasiswa");

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
                name: "id_user",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "foto_profil",
                table: "mahasiswa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "nidn",
                table: "dosen",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "nama_dosen",
                table: "dosen",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "id_user",
                table: "dosen",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "dosen",
                type: "character varying(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "foto_profil",
                table: "dosen",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tanggal_lahir",
                table: "dosen",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "cz0r6ps3jpni61t3uxnjblot", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(7602), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(7602) },
                    { "nh3qkbx360vqrf3msyclaprv", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(5970), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(5971) },
                    { "piu99f22f0r6lpkri8rhs7fp", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(6590), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(6591) },
                    { "y9sdnvb07w3pzjodp9o0vrm5", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(7125), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(7126) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "a98zlm9oog6h163b059sz7xv", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4912), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 10, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4913) },
                    { "f1hxdvbszjty24uwaxpkq546", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3060), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3057), new DateTime(2024, 9, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3060) },
                    { "fm0rt36gw4kx7koi07ebyh70", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4161), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4159), new DateTime(2024, 9, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4160), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4161) },
                    { "mbfjcd5oxdo4soa92ixq3p66", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3898), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3896), new DateTime(2024, 10, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3897), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3899) },
                    { "p50nlypmkwn30nxmfvyfnlho", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(5172), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(5170), new DateTime(2024, 9, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(5171), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(5173) },
                    { "qbjks874hy56y1g70un18ivw", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(2801), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(2791), new DateTime(2024, 11, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(2794), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(2802) },
                    { "u4u3eq7mrbpiuhrr0o9llb07", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4424), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4423), new DateTime(2024, 12, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4423), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4425) },
                    { "ww6evz4iesmyyki821icfny0", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4652), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4650), new DateTime(2024, 11, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4651), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(4652) },
                    { "x8js5t77ourxfvikmkvmvytf", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3620), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3616), new DateTime(2025, 1, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3617), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3620) },
                    { "zmaoq4cxzhz93uik444bk7bw", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3306), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3304), new DateTime(2024, 8, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3304), new DateTime(2024, 5, 28, 12, 47, 36, 594, DateTimeKind.Utc).AddTicks(3306) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_user",
                table: "mahasiswa",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "ix_dosen_id_user",
                table: "dosen",
                column: "id_user");

            migrationBuilder.AddForeignKey(
                name: "fk_dosen_application_users_id_user",
                table: "dosen",
                column: "id_user",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_application_users_id_user",
                table: "mahasiswa",
                column: "id_user",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek",
                table: "mahasiswa",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_application_users_id_user",
                table: "dosen");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_application_users_id_user",
                table: "mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek",
                table: "mahasiswa");

            migrationBuilder.DropIndex(
                name: "ix_mahasiswa_id_user",
                table: "mahasiswa");

            migrationBuilder.DropIndex(
                name: "ix_dosen_id_user",
                table: "dosen");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "cz0r6ps3jpni61t3uxnjblot");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "nh3qkbx360vqrf3msyclaprv");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "piu99f22f0r6lpkri8rhs7fp");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "y9sdnvb07w3pzjodp9o0vrm5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "a98zlm9oog6h163b059sz7xv");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "f1hxdvbszjty24uwaxpkq546");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fm0rt36gw4kx7koi07ebyh70");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "mbfjcd5oxdo4soa92ixq3p66");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "p50nlypmkwn30nxmfvyfnlho");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qbjks874hy56y1g70un18ivw");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u4u3eq7mrbpiuhrr0o9llb07");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ww6evz4iesmyyki821icfny0");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "x8js5t77ourxfvikmkvmvytf");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "zmaoq4cxzhz93uik444bk7bw");

            migrationBuilder.DropColumn(
                name: "foto_profil",
                table: "dosen");

            migrationBuilder.DropColumn(
                name: "tanggal_lahir",
                table: "dosen");

            migrationBuilder.AlterColumn<string>(
                name: "id_user",
                table: "mahasiswa",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "foto_profil",
                table: "mahasiswa",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nidn",
                table: "dosen",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "nama_dosen",
                table: "dosen",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "id_user",
                table: "dosen",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "dosen",
                type: "character varying(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36,
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek",
                table: "mahasiswa",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
