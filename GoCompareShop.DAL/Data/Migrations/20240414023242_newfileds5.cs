using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfileds5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxiumPurchaseQauntity",
                table: "DiscountGroups",
                newName: "MaxiumPurchaseQuantity");

            migrationBuilder.AddColumn<decimal>(
                name: "BasketOfferPrice",
                table: "DiscountGroups",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "BasketItems",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a178dc2-5ad6-4ace-a9a9-6e0a5c723802", "AQAAAAIAAYagAAAAEFAf7cycOdysjuLIu265tgF8pBzwKN+HESN4OA1Ro0n3tfaXwB8lO/nA7JtaA6sNIA==", "472af0d2-6d5a-48eb-b6a6-0b5f7f44eeef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasketOfferPrice",
                table: "DiscountGroups");

            migrationBuilder.RenameColumn(
                name: "MaxiumPurchaseQuantity",
                table: "DiscountGroups",
                newName: "MaxiumPurchaseQauntity");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "BasketItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3601e7b-9a19-4cce-a9b2-b92d05e8ed65", "AQAAAAIAAYagAAAAEONQoHdv7Sl7VCNtfbDDKJKOEeEiZKB7KAJi0SWyxsAqcjnY94UzeLnKu4M8jUzojA==", "19890f85-e989-4e11-af4e-64268fff7125" });
        }
    }
}
