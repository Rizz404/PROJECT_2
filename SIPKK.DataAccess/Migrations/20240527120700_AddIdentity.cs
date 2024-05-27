using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "czbpnbsct82go2bdqn64j6no");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "fklgw8dmssybz5mf5fsk5kvs");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "tj0b0r11ipr4uwtdyt2uz8z2");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "z8igc94deut80gl73ceeyiqy");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "af2geszux59skw44kmjxgu8c");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "dv4gh9k908qfecxpqxzyf8v0");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "k80qp1b5wt7dwa4vxtovyq2p");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "l856lksnkka654tv2a3sd17r");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "pl5vz4ftcxeyh0loe7fky6ae");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qzj2dwcon3bgd3c5i3y7o8ng");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "tosul4ox4z960nrunzo8ljph");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "w1377dbn20vyyxbl8itvs5h9");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "yo4dsq2v5ag3y5oe41nzn0ld");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "zrnxrvjypob9vy53fz9k4ho0");

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "dosen",
                type: "character varying(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    user_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    security_stamp = table.Column<string>(type: "text", nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    phone_number_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    two_factor_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    lockout_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    access_failed_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<string>(type: "text", nullable: false),
                    claim_type = table.Column<string>(type: "text", nullable: true),
                    claim_value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_role_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_asp_net_role_claims_asp_net_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "AspNetRoles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<string>(type: "text", nullable: false),
                    claim_type = table.Column<string>(type: "text", nullable: true),
                    claim_value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_asp_net_user_claims_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    login_provider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    provider_key = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    provider_display_name = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_logins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "fk_asp_net_user_logins_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false),
                    role_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_asp_net_user_roles_asp_net_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "AspNetRoles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_asp_net_user_roles_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false),
                    login_provider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_tokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "fk_asp_net_user_tokens_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "klfqccrp7yuvnh0d344qy9dc", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6456), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6457) },
                    { "r73zspehmi74r71c4iztluz5", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6235), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6235) },
                    { "u5v610mbbw5c435evtu77bor", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5963), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5964) },
                    { "z13ymogdk61lo6r777ar2945", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6724), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(6724) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "pdndbo0u78ao56t9xj0en61g", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4233), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4231), new DateTime(2024, 9, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4232), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4234) },
                    { "qbg2dcix2k6v90m26jiftsfm", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4502), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 12, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4503) },
                    { "r13pbwyxy0weg3kiino8bnxu", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4980), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 10, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4978), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4980) },
                    { "rrgta68zxqxrit1xeyl4z3vb", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2890), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2881), new DateTime(2024, 11, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2884), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(2891) },
                    { "s11dvwmcszzaysrt5md1qnsz", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3186), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 9, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3187) },
                    { "sek67pendj81w75p5r0nll78", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3416), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3414), new DateTime(2024, 8, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3417) },
                    { "v14iam7xw7etfgt37ez2g8cg", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3960), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3958), new DateTime(2024, 10, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3958), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3960) },
                    { "vohobmngojfyegdqvdm2o1ef", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3690), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3686), new DateTime(2025, 1, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(3690) },
                    { "wiwsvsyoz4q6bz2quihj4nty", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5291), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5289), new DateTime(2024, 9, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5290), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(5292) },
                    { "zsl3lei2u152aqwucdtwfls8", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4727), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 11, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 5, 27, 12, 6, 59, 340, DateTimeKind.Utc).AddTicks(4727) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_role_claims_role_id",
                table: "AspNetRoleClaims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_user_claims_user_id",
                table: "AspNetUserClaims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_user_logins_user_id",
                table: "AspNetUserLogins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_user_roles_role_id",
                table: "AspNetUserRoles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "klfqccrp7yuvnh0d344qy9dc");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "r73zspehmi74r71c4iztluz5");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "u5v610mbbw5c435evtu77bor");

            migrationBuilder.DeleteData(
                table: "program_studi",
                keyColumn: "id",
                keyValue: "z13ymogdk61lo6r777ar2945");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "pdndbo0u78ao56t9xj0en61g");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "qbg2dcix2k6v90m26jiftsfm");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "r13pbwyxy0weg3kiino8bnxu");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "rrgta68zxqxrit1xeyl4z3vb");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "s11dvwmcszzaysrt5md1qnsz");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "sek67pendj81w75p5r0nll78");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "v14iam7xw7etfgt37ez2g8cg");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "vohobmngojfyegdqvdm2o1ef");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "wiwsvsyoz4q6bz2quihj4nty");

            migrationBuilder.DeleteData(
                table: "proyek",
                keyColumn: "id",
                keyValue: "zsl3lei2u152aqwucdtwfls8");

            migrationBuilder.AlterColumn<string>(
                name: "id_proyek",
                table: "dosen",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "program_studi",
                columns: new[] { "id", "created_at", "deskripsi", "nama", "updated_at" },
                values: new object[,]
                {
                    { "czbpnbsct82go2bdqn64j6no", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8362), "Program studi yang mempelajari manajemen dan administrasi bisnis", "Manajemen Bisnis", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8362) },
                    { "fklgw8dmssybz5mf5fsk5kvs", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8913), "Program studi yang mempelajari prinsip dan praktik akuntansi", "Akuntansi", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(8914) },
                    { "tj0b0r11ipr4uwtdyt2uz8z2", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7232), "Program studi yang mempelajari ilmu komputer dan teknologi informasi", "Teknik Informatika", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7233) },
                    { "z8igc94deut80gl73ceeyiqy", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7811), "Program studi yang mempelajari pengembangan dan pengelolaan sistem informasi", "Sistem Informasi", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(7811) }
                });

            migrationBuilder.InsertData(
                table: "proyek",
                columns: new[] { "id", "created_at", "deskripsi", "kuota", "lokasi", "nama_proyek", "tanggal_mulai", "tanggal_selesai", "updated_at" },
                values: new object[,]
                {
                    { "af2geszux59skw44kmjxgu8c", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3975), "Proyek desain antarmuka dan pengalaman pengguna untuk website perusahaan", (short)8, "Bandung", "Desain UI/UX Website", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3972), new DateTime(2024, 9, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3973), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3975) },
                    { "dv4gh9k908qfecxpqxzyf8v0", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6375), "Proyek analisis data keuangan untuk membantu pengambilan keputusan investasi", (short)6, "Denpasar", "Analisis Data Keuangan", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6373), new DateTime(2024, 9, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6373), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6376) },
                    { "k80qp1b5wt7dwa4vxtovyq2p", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5380), "Proyek pengembangan aplikasi web e-commerce untuk toko online", (short)10, "Makassar", "Pengembangan Aplikasi Web E-Commerce", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 12, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5380) },
                    { "l856lksnkka654tv2a3sd17r", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6085), "Proyek pengembangan sistem manajemen proyek untuk perusahaan konsultan", (short)7, "Balikpapan", "Pengembangan Sistem Manajemen Proyek", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 10, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(6086) },
                    { "pl5vz4ftcxeyh0loe7fky6ae", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3708), "Proyek pengembangan aplikasi mobile untuk bisnis ritel", (short)10, "Jakarta", "Pengembangan Aplikasi Mobile", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3694), new DateTime(2024, 11, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3697), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(3709) },
                    { "qzj2dwcon3bgd3c5i3y7o8ng", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5707), "Proyek otomatisasi proses bisnis untuk meningkatkan efisiensi operasional", (short)8, "Palembang", "Otomatisasi Proses Bisnis", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 11, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5707) },
                    { "tosul4ox4z960nrunzo8ljph", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4867), "Proyek pengembangan sistem manajemen inventaris untuk perusahaan manufaktur", (short)8, "Semarang", "Sistem Manajemen Inventaris", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4865), new DateTime(2024, 10, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4866), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4868) },
                    { "w1377dbn20vyyxbl8itvs5h9", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4280), "Proyek analisis data pemasaran untuk meningkatkan strategi penjualan", (short)6, "Surabaya", "Analisis Data Pemasaran", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 8, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4280) },
                    { "yo4dsq2v5ag3y5oe41nzn0ld", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4575), "Proyek pengembangan game 3D untuk platform mobile", (short)12, "Yogyakarta", "Pengembangan Game 3D", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 1, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(4576) },
                    { "zrnxrvjypob9vy53fz9k4ho0", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5137), "Proyek analisis keamanan siber untuk meningkatkan sistem keamanan perusahaan", (short)6, "Medan", "Analisis Keamanan Siber", new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5134), new DateTime(2024, 9, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5135), new DateTime(2024, 5, 26, 11, 54, 52, 134, DateTimeKind.Utc).AddTicks(5137) }
                });

            migrationBuilder.AddForeignKey(
                name: "fk_dosen_proyek_id_proyek",
                table: "dosen",
                column: "id_proyek",
                principalTable: "proyek",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
