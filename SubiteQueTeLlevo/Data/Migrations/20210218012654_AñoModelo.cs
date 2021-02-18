using Microsoft.EntityFrameworkCore.Migrations;

namespace SubiteQueTeLlevo.Data.Migrations
{
    public partial class AñoModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Anio",
                table: "Modelos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anio",
                table: "Modelos");
        }
    }
}
