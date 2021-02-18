using Microsoft.EntityFrameworkCore.Migrations;

namespace SubiteQueTeLlevo.Data.Migrations
{
    public partial class FixBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "DisponibilidadEquipaje",
                table: "Viajes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DisponibilidadEquipaje",
                table: "Viajes",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
