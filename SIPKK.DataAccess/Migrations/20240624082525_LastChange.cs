using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LastChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "azo9cvdvlirbpy6bnglmzj7b");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "evdrkfnqro8en5iclaecksot");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "f5bev60s6722qi432liuilkl");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "j12rshdujovn6nx8xk88i19t");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "apfvcrvxfuigzch8enfv54i5");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "e22myucr3nxudwbu87etxt5q");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fiv70o00smrilhixkk82wkgb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "fq11wrhjbsft2f9zbxmcc19i");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "gkpud0yno7fw673yexzed3rm");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "ttv2jmp4h6rce0f5sy64su3w");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "u358dhu07aa5293yihyfqskx");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wb64ef4q0pu24agx3r8yudc6");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "y6k6tynjs4togcxtxrux6hve");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "yailwv3iyatztk5yezuhxbmn");

            migrationBuilder.AddColumn<bool>(
                name: "sudah_selesai",
                table: "proyek",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "verified",
                table: "proyek",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "id_mahasiswa",
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

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operasional_id_mahasiswa",
                table: "biaya_operasional",
                column: "id_mahasiswa",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_biaya_operasional_mahasiswa_id_mahasiswa",
                table: "biaya_operasional",
                column: "id_mahasiswa",
                principalTable: "mahasiswa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_biaya_operasional_mahasiswa_id_mahasiswa",
                table: "biaya_operasional");

            migrationBuilder.DropIndex(
                name: "ix_biaya_operasional_id_mahasiswa",
                table: "biaya_operasional");

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

            migrationBuilder.DropColumn(
                name: "sudah_selesai",
                table: "proyek");

            migrationBuilder.DropColumn(
                name: "verified",
                table: "proyek");

            migrationBuilder.DropColumn(
                name: "id_mahasiswa",
                table: "biaya_operasional");

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "azo9cvdvlirbpy6bnglmzj7b", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8310), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8312) },
                    { "evdrkfnqro8en5iclaecksot", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8928), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(8929) },
                    { "f5bev60s6722qi432liuilkl", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(9491), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(9493) },
                    { "j12rshdujovn6nx8xk88i19t", new DateTime(2024, 6, 17, 9, 7, 58, 910, DateTimeKind.Utc).AddTicks(89), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 6, 17, 9, 7, 58, 910, DateTimeKind.Utc).AddTicks(90) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "foto_proyek", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "apfvcrvxfuigzch8enfv54i5", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4890), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", null, (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 9, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4887), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4891) },
                    { "e22myucr3nxudwbu87etxt5q", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6468), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", null, (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6466), new DateTime(2024, 12, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6466), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6469) },
                    { "fiv70o00smrilhixkk82wkgb", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5273), "Proyek pengembangan game 3D untuk platform mobile", null, (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5269), new DateTime(2025, 2, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5270), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5274) },
                    { "fq11wrhjbsft2f9zbxmcc19i", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3939), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", null, (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3927), new DateTime(2024, 12, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3931), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(3941) },
                    { "gkpud0yno7fw673yexzed3rm", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7182), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", null, (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 10, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(7182) },
                    { "ttv2jmp4h6rce0f5sy64su3w", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5858), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", null, (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5855), new DateTime(2024, 10, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5859) },
                    { "u358dhu07aa5293yihyfqskx", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4378), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", null, (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 10, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4374), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(4380) },
                    { "wb64ef4q0pu24agx3r8yudc6", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5591), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", null, (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5589), new DateTime(2024, 11, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(5592) },
                    { "y6k6tynjs4togcxtxrux6hve", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6837), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", null, (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 11, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6837) },
                    { "yailwv3iyatztk5yezuhxbmn", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6172), "Proyek pengembangan aplikasi web e-commerce untuk toko online", null, (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6170), new DateTime(2025, 1, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6171), new DateTime(2024, 6, 17, 9, 7, 58, 909, DateTimeKind.Utc).AddTicks(6173) }
                });
        }
    }
}
