using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class PostCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
