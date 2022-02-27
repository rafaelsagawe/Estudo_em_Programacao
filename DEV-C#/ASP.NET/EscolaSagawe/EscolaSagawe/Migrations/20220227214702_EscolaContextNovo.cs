using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaSagawe.Migrations
{
    public partial class EscolaContextNovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cursoAdministrados_Cursos_CursoID",
                table: "cursoAdministrados");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Departamentos_DepartamentoID",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrutors_Cursos_CursoID",
                table: "Instrutors");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Cursos_CursoID",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Estudantes_EstudanteID",
                table: "Matriculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estudantes",
                table: "Estudantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.RenameTable(
                name: "Matriculas",
                newName: "Matricula");

            migrationBuilder.RenameTable(
                name: "Estudantes",
                newName: "Estudante");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "Curso");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_EstudanteID",
                table: "Matricula",
                newName: "IX_Matricula_EstudanteID");

            migrationBuilder.RenameIndex(
                name: "IX_Matriculas_CursoID",
                table: "Matricula",
                newName: "IX_Matricula_CursoID");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_DepartamentoID",
                table: "Curso",
                newName: "IX_Curso_DepartamentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula",
                column: "MatriculaID");

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
                name: "FK_cursoAdministrados_Curso_CursoID",
                table: "cursoAdministrados",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrutors_Curso_CursoID",
                table: "Instrutors",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Curso_CursoID",
                table: "Matricula",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Estudante_EstudanteID",
                table: "Matricula",
                column: "EstudanteID",
                principalTable: "Estudante",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Departamentos_DepartamentoID",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_cursoAdministrados_Curso_CursoID",
                table: "cursoAdministrados");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrutors_Curso_CursoID",
                table: "Instrutors");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Curso_CursoID",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Estudante_EstudanteID",
                table: "Matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estudante",
                table: "Estudante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Curso",
                table: "Curso");

            migrationBuilder.RenameTable(
                name: "Matricula",
                newName: "Matriculas");

            migrationBuilder.RenameTable(
                name: "Estudante",
                newName: "Estudantes");

            migrationBuilder.RenameTable(
                name: "Curso",
                newName: "Cursos");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_EstudanteID",
                table: "Matriculas",
                newName: "IX_Matriculas_EstudanteID");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_CursoID",
                table: "Matriculas",
                newName: "IX_Matriculas_CursoID");

            migrationBuilder.RenameIndex(
                name: "IX_Curso_DepartamentoID",
                table: "Cursos",
                newName: "IX_Cursos_DepartamentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas",
                column: "MatriculaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estudantes",
                table: "Estudantes",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_cursoAdministrados_Cursos_CursoID",
                table: "cursoAdministrados",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Departamentos_DepartamentoID",
                table: "Cursos",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrutors_Cursos_CursoID",
                table: "Instrutors",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "CursoID",
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
        }
    }
}
