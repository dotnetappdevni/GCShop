using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class fieldsnew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountQuantity",
                table: "DiscountGroups",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "DiscountGroups",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f56791-069e-4685-9de9-33ab13541db8", "AQAAAAIAAYagAAAAEAX0ZmSoFFgXLqdMXaWMcvUy6AdIwQHdzDST4/FA5ySdRl9SIh+5y9JxGiBJObPUpg==", "f5a8110c-8c3a-4ff9-ad29-d51578609625" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DiscountQuantity",
                table: "DiscountGroups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiscountPrice",
                table: "DiscountGroups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25f93105-e87e-4c44-9cfe-4e3aa1635759", "AQAAAAIAAYagAAAAEDGCQYr8EDF9Srp4c7ldGJ6fhrQgDVhiCYmmFp0RkuREjZU9+JMaKh2tUVu0Zz1eLA==", "364e0c63-3834-4ecc-b4ad-6f2512df7383" });
        }
    }
}
