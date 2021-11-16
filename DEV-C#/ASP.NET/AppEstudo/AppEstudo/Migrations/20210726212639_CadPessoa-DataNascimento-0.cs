using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEstudo.Migrations
{
    public partial class CadPessoaDataNascimento0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadPessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePrimeiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubreNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadPessoa", x => x.IdPessoa);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadPessoa");
        }
    }
}
