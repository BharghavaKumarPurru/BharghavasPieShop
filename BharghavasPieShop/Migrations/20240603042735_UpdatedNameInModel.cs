using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BharghavasPieShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedNameInModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShorppingCartId",
                table: "ShoppingCartItems",
                newName: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                newName: "ShorppingCartId");
        }
    }
}
