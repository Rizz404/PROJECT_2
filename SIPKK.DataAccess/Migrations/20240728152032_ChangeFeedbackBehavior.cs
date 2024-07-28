using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFeedbackBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_mahasiswa_feedback_feedback_id",
                table: "mahasiswa");

            migrationBuilder.DropIndex(
                name: "ix_mahasiswa_feedback_id",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "feedback_id",
                table: "mahasiswa");

            migrationBuilder.AddColumn<string>(
                name: "id_mahasiswa",
                table: "feedback",
                type: "character varying(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "ix_feedback_id_mahasiswa",
                table: "feedback",
                column: "id_mahasiswa");

            migrationBuilder.AddForeignKey(
                name: "fk_feedback_mahasiswa_id_mahasiswa",
                table: "feedback",
                column: "id_mahasiswa",
                principalTable: "mahasiswa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_feedback_mahasiswa_id_mahasiswa",
                table: "feedback");

            migrationBuilder.DropIndex(
                name: "ix_feedback_id_mahasiswa",
                table: "feedback");

            migrationBuilder.DropColumn(
                name: "id_mahasiswa",
                table: "feedback");

            migrationBuilder.AddColumn<string>(
                name: "feedback_id",
                table: "mahasiswa",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_mahasiswa_feedback_id",
                table: "mahasiswa",
                column: "feedback_id");

            migrationBuilder.AddForeignKey(
                name: "fk_mahasiswa_feedback_feedback_id",
                table: "mahasiswa",
                column: "feedback_id",
                principalTable: "feedback",
                principalColumn: "id");
        }
    }
}
