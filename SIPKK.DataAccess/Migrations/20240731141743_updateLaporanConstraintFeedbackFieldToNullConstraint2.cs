using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateLaporanConstraintFeedbackFieldToNullConstraint2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_laporan_kelompok_id_kelompok",
                table: "laporan");

            migrationBuilder.AlterColumn<string>(
                name: "id_kelompok",
                table: "laporan",
                type: "character varying(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.AddForeignKey(
                name: "fk_laporan_kelompok_id_kelompok",
                table: "laporan",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_laporan_kelompok_id_kelompok",
                table: "laporan");

            migrationBuilder.AlterColumn<string>(
                name: "id_kelompok",
                table: "laporan",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_laporan_kelompok_id_kelompok",
                table: "laporan",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
