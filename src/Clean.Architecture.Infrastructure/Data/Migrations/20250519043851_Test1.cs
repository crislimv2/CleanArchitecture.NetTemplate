using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Architecture.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contributors",
                table: "Contributors");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Contributors",
                newName: "contributors");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "products",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasure",
                table: "products",
                newName: "unitOfMeasure");

            migrationBuilder.RenameColumn(
                name: "SKU",
                table: "products",
                newName: "sku");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "products",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "products",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "products",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "products",
                newName: "brand");

            migrationBuilder.RenameColumn(
                name: "Barcode",
                table: "products",
                newName: "barcode");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "contributors",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "contributors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber_Number",
                table: "contributors",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber_Extension",
                table: "contributors",
                newName: "extension");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber_CountryCode",
                table: "contributors",
                newName: "country_code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contributors",
                table: "contributors",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contributors",
                table: "contributors");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "contributors",
                newName: "Contributors");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Products",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "unitOfMeasure",
                table: "Products",
                newName: "UnitOfMeasure");

            migrationBuilder.RenameColumn(
                name: "sku",
                table: "Products",
                newName: "SKU");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Products",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Products",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "Products",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "brand",
                table: "Products",
                newName: "Brand");

            migrationBuilder.RenameColumn(
                name: "barcode",
                table: "Products",
                newName: "Barcode");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Contributors",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contributors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Contributors",
                newName: "PhoneNumber_Number");

            migrationBuilder.RenameColumn(
                name: "extension",
                table: "Contributors",
                newName: "PhoneNumber_Extension");

            migrationBuilder.RenameColumn(
                name: "country_code",
                table: "Contributors",
                newName: "PhoneNumber_CountryCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contributors",
                table: "Contributors",
                column: "Id");
        }
    }
}
