using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaSagawe.Migrations
{
    public partial class Matricula2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoID = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoID);
                });

            migrationBuilder.CreateTable(
                name: "Estudantes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataMatricula = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudantes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    MatriculaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoID = table.Column<int>(type: "int", nullable: false),
                    EstudanteID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.MatriculaID);
                    table.ForeignKey(
                        name: "FK_Matriculas_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Estudantes_EstudanteID",
                        column: x => x.EstudanteID,
                        principalTable: "Estudantes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_CursoID",
                table: "Matriculas",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_EstudanteID",
                table: "Matriculas",
                column: "EstudanteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudantes");
        }
    }
}
