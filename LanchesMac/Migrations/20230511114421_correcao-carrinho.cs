using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class correcaocarrinho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraitemId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraItemId");

            migrationBuilder.RenameColumn(
                name: "CarrinhCompraId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraItemId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraitemId");

            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhCompraId");
        }
    }
}
