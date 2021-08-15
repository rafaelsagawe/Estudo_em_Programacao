using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class PostCategoria8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categorias_categoriasIdCategoria",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "categoriasIdCategoria",
                table: "Posts",
                newName: "CategoriasIdCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_categoriasIdCategoria",
                table: "Posts",
                newName: "IX_Posts_CategoriasIdCategoria");

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

            migrationBuilder.RenameColumn(
                name: "CategoriasIdCategoria",
                table: "Posts",
                newName: "categoriasIdCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoriasIdCategoria",
                table: "Posts",
                newName: "IX_Posts_categoriasIdCategoria");

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categorias_categoriasIdCategoria",
                table: "Posts",
                column: "categoriasIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
