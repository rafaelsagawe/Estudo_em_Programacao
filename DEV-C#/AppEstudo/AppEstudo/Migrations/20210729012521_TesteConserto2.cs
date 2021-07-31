using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEstudo.Migrations
{
    public partial class TesteConserto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsertoDetalhes_Conserto_ConsertoId",
                table: "ConsertoDetalhes");

            migrationBuilder.AlterColumn<int>(
                name: "ConsertoId",
                table: "ConsertoDetalhes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "NomeCliente",
                table: "ConsertoDetalhes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsertoDetalhes_Conserto_ConsertoId",
                table: "ConsertoDetalhes",
                column: "ConsertoId",
                principalTable: "Conserto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsertoDetalhes_Conserto_ConsertoId",
                table: "ConsertoDetalhes");

            migrationBuilder.DropColumn(
                name: "NomeCliente",
                table: "ConsertoDetalhes");

            migrationBuilder.AlterColumn<int>(
                name: "ConsertoId",
                table: "ConsertoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsertoDetalhes_Conserto_ConsertoId",
                table: "ConsertoDetalhes",
                column: "ConsertoId",
                principalTable: "Conserto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
