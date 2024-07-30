using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPKK.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNilaiAndKoutaToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nilai",
                table: "mahasiswa",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "nilai",
                table: "kelompok",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "kuota",
                table: "kelompok",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nilai",
                table: "mahasiswa");

            migrationBuilder.DropColumn(
                name: "kuota",
                table: "kelompok");

            migrationBuilder.AlterColumn<int>(
                name: "nilai",
                table: "kelompok",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }
    }
}
