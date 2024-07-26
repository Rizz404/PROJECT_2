using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddConstrainForKelompok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "c6u926w7ybdpp36atnufojh0");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "mppe9m094rxr6k04c1rc5njq");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ndm2siwreycv4od7bafmp5wv");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "y10f72qz4d5719rprleufaw6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "abysmkgeu1tsszwq6qg5ew49");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "g6mbsnqjjobbz1u1uv5j26n5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "iuhe495r5tlfuepngc7nht2k");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "lpyrszmf831c8ps59edipumj");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "plqcga5vly2gcqkxxqh26nj8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r802f59z6ptbvwed9kfx7bp6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u9nghftc1ab64azjf1pt94pb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ww4asu656jkqdhdiahcd1kwo");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xatwi0qldlz769kd5cvgitym");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "z8d6ibzspu5pu5oq9s3i81jh");

            migrationBuilder.AddColumn<string>(
                name: "nama_ketua",
                table: "kelompok",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "gv1tpqvllfig16er22uww4i6", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(3475), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(3476) },
                    { "u8demjr4kgcjwb9ws4bcr6cl", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(5873), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(5874) },
                    { "vgpn6rr6d2kaucenn0giq2bf", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(4252), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(4253) },
                    { "xjj7geh9d3krcydcx10rslec", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(5037), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(5038) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "tipe_proyek", "updated_at", "verified" },
                values: new object[,]
                {
                    { "ae8qolysqcpiqt8act8ehx72", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(9753), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(9748), new DateTime(2025, 2, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(9750), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(9754), false },
                    { "caqrsmrzzjs05vfurleulgpi", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(1331), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", false, new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(1327), new DateTime(2024, 12, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(1328), 0, new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(1332), false },
                    { "fz23bm3xeoqfsw4p1dgrhcre", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(7400), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(7394), new DateTime(2025, 3, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(7395), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(7401), false },
                    { "j34zpc8d2oz894wtvtbp5yo4", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(624), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", false, new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(619), new DateTime(2025, 1, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(620), 0, new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(625), false },
                    { "noa2pw5hjbn7alm8l4np446q", new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(2191), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", false, new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(2184), new DateTime(2024, 11, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(2186), 0, new DateTime(2024, 7, 26, 16, 38, 15, 255, DateTimeKind.Utc).AddTicks(2191), false },
                    { "ppvsdbl22nwta8c4x0kk8esl", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(4884), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(4871), new DateTime(2025, 1, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(4876), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(4887), false },
                    { "pvpujjfnqt70xwi6hh7gwwt8", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(6669), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(6663), new DateTime(2024, 10, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(6665), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(6670), false },
                    { "s1acxmfgxedmu9rf1ocb2blx", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(5720), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 11, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(5712), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(5722), false },
                    { "vxczgd7ujekrvqa4d8ojm2ew", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8233), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8228), new DateTime(2024, 12, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8230), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8235), false },
                    { "zbad3oahpcpy8d193emq5qk0", new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8987), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", false, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8982), new DateTime(2024, 11, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8984), 0, new DateTime(2024, 7, 26, 16, 38, 15, 254, DateTimeKind.Utc).AddTicks(8988), false }
                });

            migrationBuilder.CreateIndex(
                name: "ix_kelompok_id_proyek",
                table: "kelompok",
                column: "id_proyek");

            migrationBuilder.AddForeignKey(
                name: "fk_kelompok_proyek_id_proyek",
                table: "kelompok",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_kelompok_proyek_id_proyek",
                table: "kelompok");

            migrationBuilder.DropIndex(
                name: "ix_kelompok_id_proyek",
                table: "kelompok");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "gv1tpqvllfig16er22uww4i6");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "u8demjr4kgcjwb9ws4bcr6cl");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "vgpn6rr6d2kaucenn0giq2bf");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "xjj7geh9d3krcydcx10rslec");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ae8qolysqcpiqt8act8ehx72");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "caqrsmrzzjs05vfurleulgpi");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fz23bm3xeoqfsw4p1dgrhcre");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "j34zpc8d2oz894wtvtbp5yo4");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "noa2pw5hjbn7alm8l4np446q");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ppvsdbl22nwta8c4x0kk8esl");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "pvpujjfnqt70xwi6hh7gwwt8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s1acxmfgxedmu9rf1ocb2blx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vxczgd7ujekrvqa4d8ojm2ew");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "zbad3oahpcpy8d193emq5qk0");

            migrationBuilder.DropColumn(
                name: "nama_ketua",
                table: "kelompok");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "c6u926w7ybdpp36atnufojh0", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(6731), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(6732) },
                    { "mppe9m094rxr6k04c1rc5njq", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(6243), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(6244) },
                    { "ndm2siwreycv4od7bafmp5wv", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(7275), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(7276) },
                    { "y10f72qz4d5719rprleufaw6", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(7782), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(7783) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "tipe_proyek", "updated_at", "verified" },
                values: new object[,]
                {
                    { "abysmkgeu1tsszwq6qg5ew49", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4234), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4232), new DateTime(2025, 1, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4232), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4235), false },
                    { "g6mbsnqjjobbz1u1uv5j26n5", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2669), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 12, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2668), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2670), false },
                    { "iuhe495r5tlfuepngc7nht2k", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2178), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2176), new DateTime(2025, 3, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2177), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(2179), false },
                    { "lpyrszmf831c8ps59edipumj", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(5278), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(5276), new DateTime(2024, 11, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(5277), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(5279), false },
                    { "plqcga5vly2gcqkxxqh26nj8", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(538), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(528), new DateTime(2025, 1, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(531), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(538), false },
                    { "r802f59z6ptbvwed9kfx7bp6", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1620), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1618), new DateTime(2024, 10, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1618), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1621), false },
                    { "u9nghftc1ab64azjf1pt94pb", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4788), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 12, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4787), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(4789), false },
                    { "ww4asu656jkqdhdiahcd1kwo", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3721), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3718), new DateTime(2025, 2, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3719), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3721), false },
                    { "xatwi0qldlz769kd5cvgitym", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1081), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1078), new DateTime(2024, 11, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1078), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(1082), false },
                    { "z8d6ibzspu5pu5oq9s3i81jh", new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3201), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", false, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3199), new DateTime(2024, 11, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3200), 0, new DateTime(2024, 7, 26, 12, 51, 51, 179, DateTimeKind.Utc).AddTicks(3202), false }
                });
        }
    }
}
