using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuToDoApp.Data.Migrations
{
    public partial class Nota03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "Notas",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descricao",
                table: "Notas");
        }
    }
}
