using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class fieldsnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "BasketOfferPrice",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "DiscountType",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "DiscountValue",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "MaxiumPurchaseQuantity",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "MinimumPurchaseQuantity",
                table: "DiscountGroups");

            migrationBuilder.AddColumn<int>(
                name: "DiscountPrice",
                table: "DiscountGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiscountQuantity",
                table: "DiscountGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25f93105-e87e-4c44-9cfe-4e3aa1635759", "AQAAAAIAAYagAAAAEDGCQYr8EDF9Srp4c7ldGJ6fhrQgDVhiCYmmFp0RkuREjZU9+JMaKh2tUVu0Zz1eLA==", "364e0c63-3834-4ecc-b4ad-6f2512df7383" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "DiscountGroups");

            migrationBuilder.DropColumn(
                name: "DiscountQuantity",
                table: "DiscountGroups");

            migrationBuilder.AddColumn<int>(
                name: "BarCode",
                table: "DiscountGroups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BasketOfferPrice",
                table: "DiscountGroups",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DiscountGroups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountType",
                table: "DiscountGroups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountValue",
                table: "DiscountGroups",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxiumPurchaseQuantity",
                table: "DiscountGroups",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MinimumPurchaseQuantity",
                table: "DiscountGroups",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c561361c-7b1b-48f0-850b-d3614b296244", "AQAAAAIAAYagAAAAEPzyBLQCIlbEzVFvSxgghPlwk4ZWcZN+HZUhW5fdMc+uLcPxCmRmRC256gmDgFzxag==", "84dba329-6721-45a5-a1a2-aa1b1b331f2a" });
        }
    }
}
