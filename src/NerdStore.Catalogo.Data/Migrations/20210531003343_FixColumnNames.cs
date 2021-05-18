using Microsoft.EntityFrameworkCore.Migrations;

namespace NerdStore.Catalogo.Data.Migrations
{
    public partial class FixColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dimensoes_Profundidade",
                table: "Produtos",
                newName: "Profundidade");

            migrationBuilder.RenameColumn(
                name: "Dimensoes_Largura",
                table: "Produtos",
                newName: "Largura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Profundidade",
                table: "Produtos",
                newName: "Dimensoes_Profundidade");

            migrationBuilder.RenameColumn(
                name: "Largura",
                table: "Produtos",
                newName: "Dimensoes_Largura");
        }
    }
}
