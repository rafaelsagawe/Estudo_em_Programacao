using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEstudo.Migrations
{
    public partial class TesteConserto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conserto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomePeca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoDefeito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoSolucao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorMaoObra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotalConserto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conserto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsertoDetalhes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsertoId = table.Column<int>(type: "int", nullable: false),
                    PecasId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsertoDetalhes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsertoDetalhes_Conserto_ConsertoId",
                        column: x => x.ConsertoId,
                        principalTable: "Conserto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsertoDetalhes_ConsertoId",
                table: "ConsertoDetalhes",
                column: "ConsertoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsertoDetalhes");

            migrationBuilder.DropTable(
                name: "Conserto");
        }
    }
}
