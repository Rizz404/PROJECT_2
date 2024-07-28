using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNonUniqueConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_biaya_operasional_id_mahasiswa",
                table: "biaya_operasional");

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan",
                column: "id_mahasiswa");

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operasional_id_mahasiswa",
                table: "biaya_operasional",
                column: "id_mahasiswa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan");

            migrationBuilder.DropIndex(
                name: "ix_biaya_operasional_id_mahasiswa",
                table: "biaya_operasional");

            migrationBuilder.CreateIndex(
                name: "ix_laporan_id_mahasiswa",
                table: "laporan",
                column: "id_mahasiswa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_biaya_operasional_id_mahasiswa",
                table: "biaya_operasional",
                column: "id_mahasiswa",
                unique: true);
        }
    }
}
