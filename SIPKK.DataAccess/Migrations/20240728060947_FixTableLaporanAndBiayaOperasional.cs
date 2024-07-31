using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixTableLaporanAndBiayaOperasional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "foto_laporan",
                table: "laporan");

            migrationBuilder.AlterColumn<string>(
                name: "file_laporan",
                table: "laporan",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "id_kelompok",
                table: "laporan",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "id_kelompok",
                table: "biaya_operasional",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "bbhfe4snoujianckpfglwer9", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(2846), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(2847) },
                    { "f1oxxcagp9vzcgpvgbzrpmpr", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(2168), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(2169) },
                    { "um4qv4fizn4z8mmxjjyoi4uj", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(998), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(999) },
                    { "v12siqo2kasbkstb6w92cbf1", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(1623), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(1623) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "tipe_proyek", "updated_at", "verified" },
                values: new object[,]
                {
                    { "huvzlwpcoq4ug4bms0wcqo0p", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5335), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 11, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5331), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5336), false },
                    { "iq0xucqdcxdyj2a7no27l79h", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(4694), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(4684), new DateTime(2025, 1, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(4687), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(4695), false },
                    { "j12zynkuum3zpvtjp2hp904d", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8315), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8313), new DateTime(2025, 2, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8313), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8316), false },
                    { "kdrks6p3l8a021e4ndnpfp8h", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7724), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7721), new DateTime(2024, 11, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7722), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7725), false },
                    { "ko59cabknzyd960mjlu0dws3", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5962), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5959), new DateTime(2024, 10, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5960), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(5963), false },
                    { "nc76qrm6n99kgqfp4aqqfnln", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(6524), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(6522), new DateTime(2025, 3, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(6522), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(6525), false },
                    { "t13ej3z705qwv2fvl3pc1qjy", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7167), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7164), new DateTime(2024, 12, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7165), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(7180), false },
                    { "ud8j2ywrvf00cihvov9pxouu", new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(91), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", false, new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(88), new DateTime(2024, 11, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(89), 0, new DateTime(2024, 7, 28, 6, 9, 42, 425, DateTimeKind.Utc).AddTicks(92), false },
                    { "uutq5zh871uqv0h8y9zonrhc", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(9544), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(9541), new DateTime(2024, 12, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(9542), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(9545), false },
                    { "x7ncmt2y2ftlmyvdtu1pre3u", new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8856), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", false, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8853), new DateTime(2025, 1, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8854), 0, new DateTime(2024, 7, 28, 6, 9, 42, 424, DateTimeKind.Utc).AddTicks(8857), false }
                });

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_kelompok",
                table: "laporan",
                column: "id_kelompok");

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operasional_id_kelompok",
                table: "biaya_operasional",
                column: "id_kelompok");

            migrationBuilder.AddForeignKey(
                name: "fk_biaya_operasional_kelompok_id_kelompok",
                table: "biaya_operasional",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_laporan_kelompok_id_kelompok",
                table: "laporan",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_biaya_operasional_kelompok_id_kelompok",
                table: "biaya_operasional");

            migrationBuilder.DropForeignKey(
                name: "fk_laporan_kelompok_id_kelompok",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_laporan_id_kelompok",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_biaya_operasional_id_kelompok",
                table: "biaya_operasional");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "bbhfe4snoujianckpfglwer9");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "f1oxxcagp9vzcgpvgbzrpmpr");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "um4qv4fizn4z8mmxjjyoi4uj");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "v12siqo2kasbkstb6w92cbf1");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "huvzlwpcoq4ug4bms0wcqo0p");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "iq0xucqdcxdyj2a7no27l79h");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "j12zynkuum3zpvtjp2hp904d");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "kdrks6p3l8a021e4ndnpfp8h");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ko59cabknzyd960mjlu0dws3");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "nc76qrm6n99kgqfp4aqqfnln");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "t13ej3z705qwv2fvl3pc1qjy");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ud8j2ywrvf00cihvov9pxouu");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "uutq5zh871uqv0h8y9zonrhc");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "x7ncmt2y2ftlmyvdtu1pre3u");

            migrationBuilder.DropColumn(
                name: "id_kelompok",
                table: "laporan");

            migrationBuilder.DropColumn(
                name: "id_kelompok",
                table: "biaya_operasional");

            migrationBuilder.AlterColumn<string>(
                name: "file_laporan",
                table: "laporan",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "foto_laporan",
                table: "laporan",
                type: "text",
                nullable: true);

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
        }
    }
}
