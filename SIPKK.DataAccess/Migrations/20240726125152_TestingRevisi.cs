using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestingRevisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek",
                table: "mahasiswa");

            migrationBuilder.DropTable(
                name: "test");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "kx5tyv1pwviukeiss489slcl");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "p7qsf9uvi769euihj8uuuw7g");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "ptksja2l2m8l3l8k8uwvuolw");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "r122jeiuizwufsef6jigw68z");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "amsvdevco4e24mwbrn9nnfr8");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "au0ngvltvhkpmocb4id333qk");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "emfdisll88gq1d3cjlmcayt3");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ettelgsggjcjzbei6br09vv9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "i53k2o6oagrt4lnfv6erlkn9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "rday0y3zbcxyofplk4exv464");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s12qhsxlf7ms62u8fc82wfhc");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s8ajrjewqdqdeixxmb59kb08");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vcvmyf2oxw4sk3aybaby6x0z");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "xenr3ryty8114gow6gn1e775");

            migrationBuilder.RenameColumn(
                name: "id_proyek",
                table: "mahasiswa",
                newName: "id_proyek_kkp");

            migrationBuilder.RenameIndex(
                name: "ix_mahasiswa_id_proyek",
                table: "mahasiswa",
                newName: "ix_mahasiswa_id_proyek_kkp");

            migrationBuilder.AddColumn<int>(
                name: "tipe_proyek",
                table: "proyek",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "feedback_id",
                table: "mahasiswa",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "id_angkatan",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "id_kelas",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "id_kelompok",
                table: "mahasiswa",
                type: "character varying(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "role_mahasiswa",
                table: "mahasiswa",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "laporan",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "angkatan",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    tahun = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    deskripsi = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_angkatan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kelas",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    nama = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    deskripsi = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_kelas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kelompok",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    id_proyek = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    nama_kelompok = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nilai = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_kelompok", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "feedback",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    id_dosen = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_kelompok = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feedback", x => x.id);
                    table.ForeignKey(
                        name: "fk_feedback_dosen_id_dosen",
                        column: x => x.id_dosen,
                        principalTable: "dosen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_feedback_kelompok_id_kelompok",
                        column: x => x.id_kelompok,
                        principalTable: "kelompok",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_feedback_id",
                table: "mahasiswa",
                column: "feedback_id");

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_angkatan",
                table: "mahasiswa",
                column: "id_angkatan");

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_kelas",
                table: "mahasiswa",
                column: "id_kelas");

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_kelompok",
                table: "mahasiswa",
                column: "id_kelompok");

            migrationBuilder.CreateIndex(
                name: "ix_feedback_id_dosen",
                table: "feedback",
                column: "id_dosen");

            migrationBuilder.CreateIndex(
                name: "ix_feedback_id_kelompok",
                table: "feedback",
                column: "id_kelompok");

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_angkatan_id_angkatan",
                table: "mahasiswa",
                column: "id_angkatan",
                principalTable: "angkatan",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_feedback_feedback_id",
                table: "mahasiswa",
                column: "feedback_id",
                principalTable: "feedback",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_kelas_id_kelas",
                table: "mahasiswa",
                column: "id_kelas",
                principalTable: "kelas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_kelompok_id_kelompok",
                table: "mahasiswa",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek_kkp",
                table: "mahasiswa",
                column: "id_proyek_kkp",
                principalTable: "proyek",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_angkatan_id_angkatan",
                table: "mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_feedback_feedback_id",
                table: "mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_kelas_id_kelas",
                table: "mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_kelompok_id_kelompok",
                table: "mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek_kkp",
                table: "mahasiswa");

            migrationBuilder.DropTable(
                name: "angkatan");

            migrationBuilder.DropTable(
                name: "feedback");

            migrationBuilder.DropTable(
                name: "kelas");

            migrationBuilder.DropTable(
                name: "kelompok");

            migrationBuilder.DropIndex(
                name: "ix_mahasiswa_feedback_id",
                table: "mahasiswa");

            migrationBuilder.DropIndex(
                name: "ix_mahasiswa_id_angkatan",
                table: "mahasiswa");

            migrationBuilder.DropIndex(
                name: "ix_mahasiswa_id_kelas",
                table: "mahasiswa");

            migrationBuilder.DropIndex(
                name: "ix_mahasiswa_id_kelompok",
                table: "mahasiswa");

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

            migrationBuilder.DropColumn(
                name: "tipe_proyek",
                table: "proyek");

            migrationBuilder.DropColumn(
                name: "feedback_id",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "id_angkatan",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "id_kelas",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "id_kelompok",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "role_mahasiswa",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "status",
                table: "laporan");

            migrationBuilder.RenameColumn(
                name: "id_proyek_kkp",
                table: "mahasiswa",
                newName: "id_proyek");

            migrationBuilder.RenameIndex(
                name: "ix_mahasiswa_id_proyek_kkp",
                table: "mahasiswa",
                newName: "ix_mahasiswa_id_proyek");

            migrationBuilder.CreateTable(
                name: "test",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    tru_or_false = table.Column<bool>(type: "boolean", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_test", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "kx5tyv1pwviukeiss489slcl", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9454), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9455) },
                    { "p7qsf9uvi769euihj8uuuw7g", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(392), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(393) },
                    { "ptksja2l2m8l3l8k8uwvuolw", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(112), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 7, 8, 11, 32, 53, 853, DateTimeKind.Utc).AddTicks(113) },
                    { "r122jeiuizwufsef6jigw68z", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9796), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9797) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "sudah_selesai", "tanggal_mulai", "tanggal_selesai", "updated_at", "verified" },
                values: new object[,]
                {
                    { "amsvdevco4e24mwbrn9nnfr8", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6183), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 1, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6176), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6184), false },
                    { "au0ngvltvhkpmocb4id333qk", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7793), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 11, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7794), false },
                    { "emfdisll88gq1d3cjlmcayt3", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7078), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7076), new DateTime(2025, 3, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7076), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7079), false },
                    { "ettelgsggjcjzbei6br09vv9", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8675), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 12, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8673), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8676), false },
                    { "i53k2o6oagrt4lnfv6erlkn9", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9018), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9015), new DateTime(2024, 11, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(9018), false },
                    { "rday0y3zbcxyofplk4exv464", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6482), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 11, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6480), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6483), false },
                    { "s12qhsxlf7ms62u8fc82wfhc", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8400), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 1, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8401), false },
                    { "s8ajrjewqdqdeixxmb59kb08", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6802), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 10, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(6803), false },
                    { "vcvmyf2oxw4sk3aybaby6x0z", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8080), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 2, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8078), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(8080), false },
                    { "xenr3ryty8114gow6gn1e775", new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7472), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", false, new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 12, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 7, 8, 11, 32, 53, 852, DateTimeKind.Utc).AddTicks(7472), false }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_proyek_id_proyek",
                table: "mahasiswa",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id");
        }
    }
}
