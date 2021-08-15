using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class PostCategoria5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Posts_PostsIdPost",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_PostsIdPost",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "NomeCategoria",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostsIdPost",
                table: "Categorias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeCategoria",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostsIdPost",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_PostsIdPost",
                table: "Categorias",
                column: "PostsIdPost");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Posts_PostsIdPost",
                table: "Categorias",
                column: "PostsIdPost",
                principalTable: "Posts",
                principalColumn: "IdPost",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
