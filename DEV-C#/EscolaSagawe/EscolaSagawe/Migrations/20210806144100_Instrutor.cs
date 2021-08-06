using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaSagawe.Migrations
{
    public partial class Instrutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursoInstrutor");

            migrationBuilder.AddColumn<int>(
                name: "CursoID",
                table: "Instrutors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instrutors_CursoID",
                table: "Instrutors",
                column: "CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instrutors_Cursos_CursoID",
                table: "Instrutors",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instrutors_Cursos_CursoID",
                table: "Instrutors");

            migrationBuilder.DropIndex(
                name: "IX_Instrutors_CursoID",
                table: "Instrutors");

            migrationBuilder.DropColumn(
                name: "CursoID",
                table: "Instrutors");

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
                        name: "FK_CursoInstrutor_Cursos_CursosCursoID",
                        column: x => x.CursosCursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoInstrutor_Instrutors_InstrutorsID",
                        column: x => x.InstrutorsID,
                        principalTable: "Instrutors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursoInstrutor_InstrutorsID",
                table: "CursoInstrutor",
                column: "InstrutorsID");
        }
    }
}
