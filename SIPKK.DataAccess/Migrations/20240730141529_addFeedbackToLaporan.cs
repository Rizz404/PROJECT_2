using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addFeedbackToLaporan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "feedback",
                table: "laporan",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "feedback",
                table: "laporan");
        }
    }
}
