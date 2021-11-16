using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class Add_Post_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioCriador",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioCriador",
                table: "Posts");
        }
    }
}
