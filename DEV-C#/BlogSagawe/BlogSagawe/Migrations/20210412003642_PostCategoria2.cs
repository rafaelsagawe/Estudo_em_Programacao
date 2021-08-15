using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class PostCategoria2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NomeCategoria",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCategoria",
                table: "Posts");
        }
    }
}
