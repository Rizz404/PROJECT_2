using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_user = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "program_studi",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    nama = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    deskripsi = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    update_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_program_studi", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proyek",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    nama_proyek = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    deskripsi = table.Column<string>(type: "text", nullable: true),
                    tanggal_mulai = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    tanggal_selesai = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lokasi = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    kuota = table.Column<short>(type: "smallint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_proyek", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "konsentrasi",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_program_studi = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    nama = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    deskripsi = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_konsentrasi", x => x.id);
                    table.ForeignKey(
                        name: "fk_konsentrasi_program_studi_id_program_studi",
                        column: x => x.id_program_studi,
                        principalTable: "program_studi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "biaya_operational",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_proyek = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    biaya_transportasi = table.Column<int>(type: "integer", nullable: false),
                    biaya_proyek = table.Column<int>(type: "integer", nullable: false),
                    biaya_dll = table.Column<int>(type: "integer", nullable: false),
                    keterangan = table.Column<string>(type: "text", nullable: true),
                    tanggal_biaya = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_biaya_operational", x => x.id);
                    table.ForeignKey(
                        name: "fk_biaya_operational_proyek_id_proyek",
                        column: x => x.id_proyek,
                        principalTable: "proyek",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dosen",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_user = table.Column<string>(type: "text", nullable: false),
                    nama_dosen = table.Column<string>(type: "text", nullable: false),
                    id_proyek = table.Column<string>(type: "text", nullable: false),
                    nidn = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dosen", x => x.id);
                    table.ForeignKey(
                        name: "fk_dosen_proyek_id_proyek",
                        column: x => x.id_proyek,
                        principalTable: "proyek",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laporan",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_proyek = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    keterangan = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laporan", x => x.id);
                    table.ForeignKey(
                        name: "fk_laporan_proyek_id_proyek",
                        column: x => x.id_proyek,
                        principalTable: "proyek",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mahasiswa",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_user = table.Column<string>(type: "text", nullable: false),
                    nim = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    tanggal_lahir = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    foto_profil = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    id_program_studi = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_konsentrasi = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_proyek = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    semester = table.Column<short>(type: "smallint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mahasiswa", x => x.id);
                    table.ForeignKey(
                        name: "fk_mahasiswa_konsentrasi_id_konsentrasi",
                        column: x => x.id_konsentrasi,
                        principalTable: "konsentrasi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_mahasiswa_program_studi_id_program_studi",
                        column: x => x.id_program_studi,
                        principalTable: "program_studi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_mahasiswa_proyek_id_proyek",
                        column: x => x.id_proyek,
                        principalTable: "proyek",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pendaftaran",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_mahasiswa = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    tanggal_pendaftaran = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pendaftaran", x => x.id);
                    table.ForeignKey(
                        name: "fk_pendaftaran_mahasiswa_id_mahasiswa",
                        column: x => x.id_mahasiswa,
                        principalTable: "mahasiswa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "persyaratan",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    id_mahasiswa = table.Column<string>(type: "character varying(36)", maxLength: 36, nullable: false),
                    ket_sehat = table.Column<bool>(type: "boolean", nullable: false),
                    ket_pembayaran = table.Column<bool>(type: "boolean", nullable: false),
                    ket_orang_tua = table.Column<bool>(type: "boolean", nullable: false),
                    ket_kelakuan_baik = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persyaratan", x => x.id);
                    table.ForeignKey(
                        name: "fk_persyaratan_mahasiswa_id_mahasiswa",
                        column: x => x.id_mahasiswa,
                        principalTable: "mahasiswa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operational_id_proyek",
                table: "biaya_operational",
                column: "id_proyek",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_dosen_id_proyek",
                table: "dosen",
                column: "id_proyek");

            migrationBuilder.CreateIndex(
                name: "ix_konsentrasi_id_program_studi",
                table: "konsentrasi",
                column: "id_program_studi");

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_proyek",
                table: "laporan",
                column: "id_proyek",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_konsentrasi",
                table: "mahasiswa",
                column: "id_konsentrasi");

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_program_studi",
                table: "mahasiswa",
                column: "id_program_studi");

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_id_proyek",
                table: "mahasiswa",
                column: "id_proyek");

            migrationBuilder.CreateIndex(
                name: "ix_pendaftaran_id_mahasiswa",
                table: "pendaftaran",
                column: "id_mahasiswa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_persyaratan_id_mahasiswa",
                table: "persyaratan",
                column: "id_mahasiswa",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "biaya_operational");

            migrationBuilder.DropTable(
                name: "dosen");

            migrationBuilder.DropTable(
                name: "laporan");

            migrationBuilder.DropTable(
                name: "pendaftaran");

            migrationBuilder.DropTable(
                name: "persyaratan");

            migrationBuilder.DropTable(
                name: "mahasiswa");

            migrationBuilder.DropTable(
                name: "konsentrasi");

            migrationBuilder.DropTable(
                name: "proyek");

            migrationBuilder.DropTable(
                name: "program_studi");
        }
    }
}
