using Microsoft.EntityFrameworkCore.Migrations;

namespace SubiteQueTeLlevo.Data.Migrations
{
    public partial class ModelClassesFixEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoViaje",
                table: "Viajes");

            migrationBuilder.DropColumn(
                name: "EstadoViajePerfil",
                table: "ViajePerfil");

            migrationBuilder.CreateTable(
                name: "EstadoViaje",
                columns: table => new
                {
                    EstadoViajeId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoViaje", x => x.EstadoViajeId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoViajePerfil",
                columns: table => new
                {
                    EstadoViajePerfilId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoViajePerfil", x => x.EstadoViajePerfilId);
                });

            migrationBuilder.InsertData(
                table: "EstadoViaje",
                columns: new[] { "EstadoViajeId", "Nombre" },
                values: new object[,]
                {
                    { 0, "Pendiente" },
                    { 1, "Cancelado" },
                    { 2, "Completado" }
                });

            migrationBuilder.InsertData(
                table: "EstadoViajePerfil",
                columns: new[] { "EstadoViajePerfilId", "Nombre" },
                values: new object[,]
                {
                    { 0, "Cancelado" },
                    { 1, "Completado" },
                    { 2, "PendienteAceptacion" },
                    { 3, "Reservado" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viajes_EstadoViajeId",
                table: "Viajes",
                column: "EstadoViajeId");

            migrationBuilder.CreateIndex(
                name: "IX_ViajePerfil_EstadoViajePerfilId",
                table: "ViajePerfil",
                column: "EstadoViajePerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_ViajePerfil_EstadoViajePerfil_EstadoViajePerfilId",
                table: "ViajePerfil",
                column: "EstadoViajePerfilId",
                principalTable: "EstadoViajePerfil",
                principalColumn: "EstadoViajePerfilId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Viajes_EstadoViaje_EstadoViajeId",
                table: "Viajes",
                column: "EstadoViajeId",
                principalTable: "EstadoViaje",
                principalColumn: "EstadoViajeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViajePerfil_EstadoViajePerfil_EstadoViajePerfilId",
                table: "ViajePerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Viajes_EstadoViaje_EstadoViajeId",
                table: "Viajes");

            migrationBuilder.DropTable(
                name: "EstadoViaje");

            migrationBuilder.DropTable(
                name: "EstadoViajePerfil");

            migrationBuilder.DropIndex(
                name: "IX_Viajes_EstadoViajeId",
                table: "Viajes");

            migrationBuilder.DropIndex(
                name: "IX_ViajePerfil_EstadoViajePerfilId",
                table: "ViajePerfil");

            migrationBuilder.AddColumn<int>(
                name: "EstadoViaje",
                table: "Viajes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoViajePerfil",
                table: "ViajePerfil",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
