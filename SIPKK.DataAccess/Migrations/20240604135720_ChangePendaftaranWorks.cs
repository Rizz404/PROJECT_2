using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangePendaftaranWorks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "id_proyek",
                table: "pendaftaran",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "id_user",
                table: "mahasiswa",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "q9m6t1niderm5l4noedcywxp", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(511), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(512) },
                    { "vae2kc2r99g1u77mpyb11q9a", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(996), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(997) },
                    { "yyorngksshrrgp6tglx2o2gd", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(1620), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(1621) },
                    { "zfa4ekccx81hmjt2kf0h7117", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(2389), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 4, 13, 57, 18, 775, DateTimeKind.Utc).AddTicks(2389) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "d13zjfd86n0uzlea2gi8t6yq", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7537), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 10, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7538) },
                    { "gu6gnnnhingr47cirdg74d6v", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8134), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8130), new DateTime(2025, 2, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8131), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8134) },
                    { "j11ojzpsycgzbjzr41h4zx0r", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8608), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8606), new DateTime(2024, 10, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8607), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8609) },
                    { "k3ykb7mlfwhe8n5jqykqxvcv", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8898), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 1, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8898) },
                    { "r12d50v1uwwqos10jord9tjo", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7242), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7232), new DateTime(2024, 12, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7234), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7243) },
                    { "r2muho35eggxg8l5rvlq0s6v", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9673), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9671), new DateTime(2024, 10, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9672), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9674) },
                    { "t47pka0go0g31d02fv20mxy5", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8357), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8355), new DateTime(2024, 11, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(8358) },
                    { "uekpj3y89ys6mk12fpnsvngt", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7835), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 9, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(7835) },
                    { "vv5h531hxed5htlfx7wwqm7u", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9399), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 11, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9398), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9399) },
                    { "xkbsifcqonjs58w2uhyz8p8j", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9178), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9176), new DateTime(2024, 12, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9177), new DateTime(2024, 6, 4, 13, 57, 18, 774, DateTimeKind.Utc).AddTicks(9179) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_pendaftaran_proyek_id_mahasiswa",
                table: "pendaftaran",
                column: "id_mahasiswa",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_pendaftaran_proyek_id_mahasiswa",
                table: "pendaftaran");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "q9m6t1niderm5l4noedcywxp");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "vae2kc2r99g1u77mpyb11q9a");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "yyorngksshrrgp6tglx2o2gd");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "zfa4ekccx81hmjt2kf0h7117");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "d13zjfd86n0uzlea2gi8t6yq");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gu6gnnnhingr47cirdg74d6v");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "j11ojzpsycgzbjzr41h4zx0r");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "k3ykb7mlfwhe8n5jqykqxvcv");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r12d50v1uwwqos10jord9tjo");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r2muho35eggxg8l5rvlq0s6v");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "t47pka0go0g31d02fv20mxy5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "uekpj3y89ys6mk12fpnsvngt");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vv5h531hxed5htlfx7wwqm7u");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xkbsifcqonjs58w2uhyz8p8j");

            migrationBuilder.DropColumn(
                name: "id_proyek",
                table: "pendaftaran");

            migrationBuilder.AlterColumn<string>(
                name: "id_user",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

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
        }
    }
}
