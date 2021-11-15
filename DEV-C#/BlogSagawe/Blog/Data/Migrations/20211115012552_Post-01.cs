using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class Post01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    idPost = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePost = table.Column<string>(nullable: true),
                    ResumoPost = table.Column<string>(nullable: true),
                    ConteudoPost = table.Column<string>(nullable: true),
                    CategoriasPost = table.Column<string>(nullable: true),
                    DataPost = table.Column<DateTime>(nullable: false),
                    UsuarioCriador = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.idPost);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
