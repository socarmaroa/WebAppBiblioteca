using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppBiblioteca.Migrations
{
    public partial class Usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_General_TipoGeneral_TipoGeneralId",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_Libro_General_AreaId",
                table: "Libro");

            migrationBuilder.DropForeignKey(
                name: "FK_Libro_General_TipoLibroId",
                table: "Libro");

            migrationBuilder.DropForeignKey(
                name: "FK_Libro_General_UbicacionId",
                table: "Libro");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_LibroId",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Libro_AreaId",
                table: "Libro");

            migrationBuilder.DropIndex(
                name: "IX_Libro_TipoLibroId",
                table: "Libro");

            migrationBuilder.DropIndex(
                name: "IX_Libro_UbicacionId",
                table: "Libro");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Prestamo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UbicacionId",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoLibroId",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Editorial",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoGeneralId",
                table: "General",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoIdentificacionId = table.Column<int>(nullable: false),
                    Identificacion = table.Column<string>(nullable: true),
                    Pnombre = table.Column<string>(nullable: true),
                    Snombre = table.Column<string>(nullable: true),
                    Papellido = table.Column<string>(nullable: true),
                    Sapellido = table.Column<string>(nullable: true),
                    GeneroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_General_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_General_TipoIdentificacionId",
                        column: x => x.TipoIdentificacionId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    EstadoUsuarioId = table.Column<int>(nullable: true),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_General_EstadoUsuarioId",
                        column: x => x.EstadoUsuarioId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_GeneroId",
                table: "Persona",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoIdentificacionId",
                table: "Persona",
                column: "TipoIdentificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstadoUsuarioId",
                table: "Usuario",
                column: "EstadoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PersonaId",
                table: "Usuario",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_General_TipoGeneral_TipoGeneralId",
                table: "General",
                column: "TipoGeneralId",
                principalTable: "TipoGeneral",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_General_TipoGeneral_TipoGeneralId",
                table: "General");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Prestamo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Libro",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UbicacionId",
                table: "Libro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Libro",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "TipoLibroId",
                table: "Libro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Editorial",
                table: "Libro",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Libro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TipoGeneralId",
                table: "General",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_LibroId",
                table: "Prestamo",
                column: "LibroId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_General_TipoGeneral_TipoGeneralId",
                table: "General",
                column: "TipoGeneralId",
                principalTable: "TipoGeneral",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_General_AreaId",
                table: "Libro",
                column: "AreaId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_General_TipoLibroId",
                table: "Libro",
                column: "TipoLibroId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Libro_General_UbicacionId",
                table: "Libro",
                column: "UbicacionId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
