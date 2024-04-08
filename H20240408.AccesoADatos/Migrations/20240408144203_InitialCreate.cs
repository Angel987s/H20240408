using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H20240408.AccesoADatos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonasH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimientoH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoH = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstatusH = table.Column<byte>(type: "tinyint", nullable: false),
                    ComentarioH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasH", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasH");
        }
    }
}
