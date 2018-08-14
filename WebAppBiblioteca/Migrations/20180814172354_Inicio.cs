using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppBiblioteca.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoGeneral",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoGeneral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoGeneralId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Id);
                    table.ForeignKey(
                        name: "FK_General_TipoGeneral_TipoGeneralId",
                        column: x => x.TipoGeneralId,
                        principalTable: "TipoGeneral",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Editorial = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    UbicacionId = table.Column<int>(nullable: true),
                    TipoLibroId = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: true),
                    DiasPrestamo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libro_General_AreaId",
                        column: x => x.AreaId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libro_General_TipoLibroId",
                        column: x => x.TipoLibroId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libro_General_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_General_TipoGeneralId",
                table: "General",
                column: "TipoGeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_AreaId",
                table: "Libro",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_TipoLibroId",
                table: "Libro",
                column: "TipoLibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_UbicacionId",
                table: "Libro",
                column: "UbicacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.DropTable(
                name: "TipoGeneral");
        }
    }
}
