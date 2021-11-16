using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCoreCodeFist.Data.Migrations
{
    public partial class Postscategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categorias_CategoriasIDCategorias",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoriasIDCategorias",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategoriasIDCategorias",
                table: "Posts");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_IDCategorias",
                table: "Posts",
                column: "IDCategorias");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categorias_IDCategorias",
                table: "Posts",
                column: "IDCategorias",
                principalTable: "Categorias",
                principalColumn: "IDCategorias",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categorias_IDCategorias",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_IDCategorias",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "CategoriasIDCategorias",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoriasIDCategorias",
                table: "Posts",
                column: "CategoriasIDCategorias");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categorias_CategoriasIDCategorias",
                table: "Posts",
                column: "CategoriasIDCategorias",
                principalTable: "Categorias",
                principalColumn: "IDCategorias",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
