using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class PostCategoria4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categorias_CategoriasIdCategoria",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoriasIdCategoria",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategoriasIdCategoria",
                table: "Posts");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Posts_PostsIdPost",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_PostsIdPost",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "PostsIdPost",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "CategoriasIdCategoria",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoriasIdCategoria",
                table: "Posts",
                column: "CategoriasIdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categorias_CategoriasIdCategoria",
                table: "Posts",
                column: "CategoriasIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
