using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LargoSebastian_Progreso1.Migrations
{
    /// <inheritdoc />
    public partial class PruebaProgresoI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LargoS",
                columns: table => new
                {
                    IdNombre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entero = table.Column<int>(type: "int", nullable: false),
                    Decimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Palabra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VerdaderoFalso = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LargoS", x => x.IdNombre);
                });

            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LargoS = table.Column<int>(type: "int", nullable: false),
                    LargoSIdNombre = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.IdCelular);
                    table.ForeignKey(
                        name: "FK_Celular_LargoS_LargoSIdNombre",
                        column: x => x.LargoSIdNombre,
                        principalTable: "LargoS",
                        principalColumn: "IdNombre");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_LargoSIdNombre",
                table: "Celular",
                column: "LargoSIdNombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Celular");

            migrationBuilder.DropTable(
                name: "LargoS");
        }
    }
}
