using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Semana12.Migrations
{
    /// <inheritdoc />
    public partial class v2_creandobasededatos3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Grades");
        }
    }
}
