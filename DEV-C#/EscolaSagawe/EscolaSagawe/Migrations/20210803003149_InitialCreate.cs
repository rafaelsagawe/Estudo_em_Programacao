using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaSagawe.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudante",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DataMatricula = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudante", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instrutor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DataAdmicacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrutor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Valor = table.Column<decimal>(type: "money", nullable: false),
                    DataInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstrutorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoID);
                    table.ForeignKey(
                        name: "FK_Departamentos_Instrutor_InstrutorID",
                        column: x => x.InstrutorID,
                        principalTable: "Instrutor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    InstrutorID = table.Column<int>(type: "int", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.InstrutorID);
                    table.ForeignKey(
                        name: "FK_Salas_Instrutor_InstrutorID",
                        column: x => x.InstrutorID,
                        principalTable: "Instrutor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    CursoID = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notas = table.Column<int>(type: "int", nullable: false),
                    DepartamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.CursoID);
                    table.ForeignKey(
                        name: "FK_Curso_Departamentos_DepartamentoID",
                        column: x => x.DepartamentoID,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoInstrutor",
                columns: table => new
                {
                    CursosCursoID = table.Column<int>(type: "int", nullable: false),
                    InstrutorsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoInstrutor", x => new { x.CursosCursoID, x.InstrutorsID });
                    table.ForeignKey(
                        name: "FK_CursoInstrutor_Curso_CursosCursoID",
                        column: x => x.CursosCursoID,
                        principalTable: "Curso",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoInstrutor_Instrutor_InstrutorsID",
                        column: x => x.InstrutorsID,
                        principalTable: "Instrutor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Matriculas_Curso_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Curso",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Estudante_EstudanteID",
                        column: x => x.EstudanteID,
                        principalTable: "Estudante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_DepartamentoID",
                table: "Curso",
                column: "DepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_CursoInstrutor_InstrutorsID",
                table: "CursoInstrutor",
                column: "InstrutorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_InstrutorID",
                table: "Departamentos",
                column: "InstrutorID");

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
                name: "CursoInstrutor");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudante");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Instrutor");
        }
    }
}
