using Microsoft.EntityFrameworkCore.Migrations;

namespace EstoqueAPP.Migrations
{
    public partial class Versao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoriasIdCategoria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CategoriasIdCategoria",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdCategoria",
                table: "Produtos",
                column: "IdCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.DropIndex(
                name: "IX_Produtos_IdCategoria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriasIdCategoria",
                table: "Produtos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriasIdCategoria",
                table: "Produtos",
                column: "CategoriasIdCategoria");

        }
    }
}
