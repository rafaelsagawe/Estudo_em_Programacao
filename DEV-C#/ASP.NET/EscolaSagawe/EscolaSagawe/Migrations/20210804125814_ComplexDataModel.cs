using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaSagawe.Migrations
{
    public partial class ComplexDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Departamentos_DepartamentoID",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoInstrutor_Curso_CursosCursoID",
                table: "CursoInstrutor");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoInstrutor_Instrutor_InstrutorsID",
                table: "CursoInstrutor");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instrutor_InstrutorID",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Curso_CursoID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Estudante_EstudanteID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Instrutor_InstrutorID",
                table: "Salas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrutor",
                table: "Instrutor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estudante",
                table: "Estudante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Curso",
                table: "Curso");

            migrationBuilder.RenameTable(
                name: "Instrutor",
                newName: "Instrutors");

            migrationBuilder.RenameTable(
                name: "Estudante",
                newName: "Estudantes");

            migrationBuilder.RenameTable(
                name: "Curso",
                newName: "Cursos");

            migrationBuilder.RenameIndex(
                name: "IX_Curso_DepartamentoID",
                table: "Cursos",
                newName: "IX_Cursos_DepartamentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrutors",
                table: "Instrutors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estudantes",
                table: "Estudantes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "CursoID");

            migrationBuilder.CreateTable(
                name: "cursoAdministrados",
                columns: table => new
                {
                    InstrutorID = table.Column<int>(type: "int", nullable: false),
                    CursoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursoAdministrados", x => new { x.CursoID, x.InstrutorID });
                    table.ForeignKey(
                        name: "FK_cursoAdministrados_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursoAdministrados_Instrutors_InstrutorID",
                        column: x => x.InstrutorID,
                        principalTable: "Instrutors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cursoAdministrados_InstrutorID",
                table: "cursoAdministrados",
                column: "InstrutorID");

            migrationBuilder.AddForeignKey(
                name: "FK_CursoInstrutor_Cursos_CursosCursoID",
                table: "CursoInstrutor",
                column: "CursosCursoID",
                principalTable: "Cursos",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoInstrutor_Instrutors_InstrutorsID",
                table: "CursoInstrutor",
                column: "InstrutorsID",
                principalTable: "Instrutors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Departamentos_DepartamentoID",
                table: "Cursos",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instrutors_InstrutorID",
                table: "Departamentos",
                column: "InstrutorID",
                principalTable: "Instrutors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Cursos_CursoID",
                table: "Matriculas",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Estudantes_EstudanteID",
                table: "Matriculas",
                column: "EstudanteID",
                principalTable: "Estudantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Instrutors_InstrutorID",
                table: "Salas",
                column: "InstrutorID",
                principalTable: "Instrutors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursoInstrutor_Cursos_CursosCursoID",
                table: "CursoInstrutor");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoInstrutor_Instrutors_InstrutorsID",
                table: "CursoInstrutor");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Departamentos_DepartamentoID",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instrutors_InstrutorID",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Cursos_CursoID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Estudantes_EstudanteID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salas_Instrutors_InstrutorID",
                table: "Salas");

            migrationBuilder.DropTable(
                name: "cursoAdministrados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrutors",
                table: "Instrutors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estudantes",
                table: "Estudantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.RenameTable(
                name: "Instrutors",
                newName: "Instrutor");

            migrationBuilder.RenameTable(
                name: "Estudantes",
                newName: "Estudante");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "Curso");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_DepartamentoID",
                table: "Curso",
                newName: "IX_Curso_DepartamentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrutor",
                table: "Instrutor",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estudante",
                table: "Estudante",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Curso",
                table: "Curso",
                column: "CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Departamentos_DepartamentoID",
                table: "Curso",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoInstrutor_Curso_CursosCursoID",
                table: "CursoInstrutor",
                column: "CursosCursoID",
                principalTable: "Curso",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoInstrutor_Instrutor_InstrutorsID",
                table: "CursoInstrutor",
                column: "InstrutorsID",
                principalTable: "Instrutor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instrutor_InstrutorID",
                table: "Departamentos",
                column: "InstrutorID",
                principalTable: "Instrutor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Curso_CursoID",
                table: "Matriculas",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Estudante_EstudanteID",
                table: "Matriculas",
                column: "EstudanteID",
                principalTable: "Estudante",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salas_Instrutor_InstrutorID",
                table: "Salas",
                column: "InstrutorID",
                principalTable: "Instrutor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
