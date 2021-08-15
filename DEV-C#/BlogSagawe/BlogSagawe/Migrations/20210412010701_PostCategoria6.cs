using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSagawe.Migrations
{
    public partial class PostCategoria6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoriasIdCategoria",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_categoriasIdCategoria",
                table: "Posts",
                column: "categoriasIdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categorias_categoriasIdCategoria",
                table: "Posts",
                column: "categoriasIdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categorias_categoriasIdCategoria",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_categoriasIdCategoria",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "categoriasIdCategoria",
                table: "Posts");
        }
    }
}
