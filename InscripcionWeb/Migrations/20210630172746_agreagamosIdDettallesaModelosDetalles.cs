using Microsoft.EntityFrameworkCore.Migrations;

namespace InscripcionWeb.Migrations
{
    public partial class agreagamosIdDettallesaModelosDetalles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesAlumnosCarreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(nullable: false),
                    CarreraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAlumnosCarreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesAlumnosCarreras_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAlumnosCarreras_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesAlumnosMaterias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(nullable: false),
                    MateriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAlumnosMaterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesAlumnosMaterias_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAlumnosMaterias_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAlumnosCarreras_AlumnoId",
                table: "DetallesAlumnosCarreras",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAlumnosCarreras_CarreraId",
                table: "DetallesAlumnosCarreras",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAlumnosMaterias_AlumnoId",
                table: "DetallesAlumnosMaterias",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAlumnosMaterias_MateriaId",
                table: "DetallesAlumnosMaterias",
                column: "MateriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesAlumnosCarreras");

            migrationBuilder.DropTable(
                name: "DetallesAlumnosMaterias");
        }
    }
}
