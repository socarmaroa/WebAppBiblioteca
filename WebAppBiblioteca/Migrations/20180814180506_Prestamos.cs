using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppBiblioteca.Migrations
{
    public partial class Prestamos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LibroId = table.Column<int>(nullable: true),
                    FechaPrestamo = table.Column<DateTime>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamo_Libro_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_LibroId",
                table: "Prestamo",
                column: "LibroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamo");
        }
    }
}
