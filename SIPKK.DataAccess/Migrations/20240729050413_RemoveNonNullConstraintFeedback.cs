using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNonNullConstraintFeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_feedback_kelompok_id_kelompok",
                table: "feedback");

            migrationBuilder.DropForeignKey(
                name: "fk_feedback_mahasiswa_id_mahasiswa",
                table: "feedback");

            migrationBuilder.AlterColumn<string>(
                name: "file_laporan",
                table: "laporan",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "id_mahasiswa",
                table: "feedback",
                type: "character varying(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "id_kelompok",
                table: "feedback",
                type: "character varying(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36);

            migrationBuilder.AddForeignKey(
                name: "fk_feedback_kelompok_id_kelompok",
                table: "feedback",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_feedback_mahasiswa_id_mahasiswa",
                table: "feedback",
                column: "id_mahasiswa",
                principalTable: "mahasiswa",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_feedback_kelompok_id_kelompok",
                table: "feedback");

            migrationBuilder.DropForeignKey(
                name: "fk_feedback_mahasiswa_id_mahasiswa",
                table: "feedback");

            migrationBuilder.AlterColumn<string>(
                name: "file_laporan",
                table: "laporan",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id_mahasiswa",
                table: "feedback",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id_kelompok",
                table: "feedback",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_feedback_kelompok_id_kelompok",
                table: "feedback",
                column: "id_kelompok",
                principalTable: "kelompok",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_feedback_mahasiswa_id_mahasiswa",
                table: "feedback",
                column: "id_mahasiswa",
                principalTable: "mahasiswa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
