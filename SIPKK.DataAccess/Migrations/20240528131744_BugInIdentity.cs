using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BugInIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_application_users_id_user",
                table: "dosen");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_application_users_id_user",
                table: "mahasiswa");

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
                name: "discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "hlak0kc0eez50uz6huvlaikk", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(3206), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(3206) },
                    { "jrueckl8wbqajg47ylxadyxy", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(2577), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(2578) },
                    { "kamvxheundqo9dwcs5w4s28w", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(3929), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(3930) },
                    { "ygp1m0nsne0ku6zp4j8j6rd1", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(1576), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(1578) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "daro5f2bbmx7h76bavm097t6", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9707), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9701), new DateTime(2024, 10, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9703), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9708) },
                    { "i6f267qo3anntgfb3dtdcbye", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6424), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6409), new DateTime(2024, 11, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6424) },
                    { "j44n23ral0gs6bf1kzcotlm4", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6961), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 9, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6956), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(6962) },
                    { "ltt8wspoycrv7b5orc8xeeib", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8649), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8646), new DateTime(2024, 9, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8647), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8650) },
                    { "n118jgrbx8qx4rq2zazf6323", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8006), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(7995), new DateTime(2025, 1, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(7998), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8006) },
                    { "qeeruzmwuu081l9ap2c9mtih", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(198), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(193), new DateTime(2024, 9, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(195), new DateTime(2024, 5, 28, 13, 17, 40, 130, DateTimeKind.Utc).AddTicks(198) },
                    { "r1xvl4bcidm7nqwpp50hbdpd", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8938), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 12, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8939) },
                    { "w13qfdmrerbctm7tgfxxc551", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9234), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9231), new DateTime(2024, 11, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9232), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(9235) },
                    { "xose2qf2p5d8uvpnqnma13y7", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(7422), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(7418), new DateTime(2024, 8, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(7422) },
                    { "y1o9lcf261s3reyl57bgsq08", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8391), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 10, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 5, 28, 13, 17, 40, 129, DateTimeKind.Utc).AddTicks(8392) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_dosen_application_user_id_user",
                table: "dosen",
                column: "id_user",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_application_user_id_user",
                table: "mahasiswa",
                column: "id_user",
                principalTable: "AspNetUsers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_application_user_id_user",
                table: "dosen");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_application_user_id_user",
                table: "mahasiswa");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "hlak0kc0eez50uz6huvlaikk");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "jrueckl8wbqajg47ylxadyxy");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "kamvxheundqo9dwcs5w4s28w");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ygp1m0nsne0ku6zp4j8j6rd1");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "daro5f2bbmx7h76bavm097t6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "i6f267qo3anntgfb3dtdcbye");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "j44n23ral0gs6bf1kzcotlm4");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ltt8wspoycrv7b5orc8xeeib");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "n118jgrbx8qx4rq2zazf6323");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qeeruzmwuu081l9ap2c9mtih");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r1xvl4bcidm7nqwpp50hbdpd");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "w13qfdmrerbctm7tgfxxc551");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xose2qf2p5d8uvpnqnma13y7");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "y1o9lcf261s3reyl57bgsq08");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "discriminator",
                table: "AspNetUsers",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

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
        }
    }
}
