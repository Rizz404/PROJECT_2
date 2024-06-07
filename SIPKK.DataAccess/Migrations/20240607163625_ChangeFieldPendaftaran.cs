using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFieldPendaftaran : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "laa8a2o8f8ftk2eyxiz0i1g0", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(7693), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(7694) },
                    { "lirzmjy9ncb43uhlr32zt136", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6144), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6146) },
                    { "tjn9x7ggv6yaassyzsfurc80", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(8489), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(8490) },
                    { "xtp52d8daii686rrdp9vn4mr", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6840), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(6841) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "bebbsi7nuntawyz7briw3mej", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1829), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 10, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1830) },
                    { "c13untxobtks4xrk87eqauko", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4206), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4202), new DateTime(2024, 12, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4203), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4206) },
                    { "d9pn2vpw9e3ryy9eboycgm3y", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4537), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 11, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4538) },
                    { "fyzcw22zdiwafkbsmz1eumno", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4930), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 10, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4928), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(4931) },
                    { "h314hmnxxjco2l5be4qc6hhq", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2652), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 2, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2649), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2653) },
                    { "ng3rdzwnhel3ficjbjogwuai", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3407), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3404), new DateTime(2024, 10, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3408) },
                    { "q985ll02bo80ijpcssp2mu7t", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3801), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 1, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(3802) },
                    { "qngnmnhamh0hwl5xv5tnb5p0", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2990), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 11, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2991) },
                    { "sannt2z90yargmu187o7xd87", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1396), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1381), new DateTime(2024, 12, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(1396) },
                    { "u7tfds31ibhuolv0h6ykom6f", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2205), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 9, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 6, 7, 16, 36, 20, 294, DateTimeKind.Utc).AddTicks(2206) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_pendaftaran_id_proyek",
                table: "pendaftaran",
                column: "id_proyek");

            migrationBuilder.AddForeignKey(
                name: "fk_pendaftaran_proyek_id_proyek",
                table: "pendaftaran",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_pendaftaran_proyek_id_proyek",
                table: "pendaftaran");

            migrationBuilder.DropIndex(
                name: "ix_pendaftaran_id_proyek",
                table: "pendaftaran");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "laa8a2o8f8ftk2eyxiz0i1g0");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "lirzmjy9ncb43uhlr32zt136");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "tjn9x7ggv6yaassyzsfurc80");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "xtp52d8daii686rrdp9vn4mr");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "bebbsi7nuntawyz7briw3mej");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "c13untxobtks4xrk87eqauko");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "d9pn2vpw9e3ryy9eboycgm3y");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fyzcw22zdiwafkbsmz1eumno");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "h314hmnxxjco2l5be4qc6hhq");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ng3rdzwnhel3ficjbjogwuai");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "q985ll02bo80ijpcssp2mu7t");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qngnmnhamh0hwl5xv5tnb5p0");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "sannt2z90yargmu187o7xd87");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u7tfds31ibhuolv0h6ykom6f");

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
    }
}
