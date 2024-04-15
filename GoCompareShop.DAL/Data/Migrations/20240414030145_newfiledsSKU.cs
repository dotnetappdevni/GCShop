using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfiledsSKU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "979123f9-e335-41c6-9091-3f9937c0a931", "AQAAAAIAAYagAAAAEO0phzvzI5aY4UpuLYisckUahmcxpUcmYjKFxpcCAT3sLUv1K+38h1r1JlNDEv4G7A==", "7e7d00d5-75ab-4530-a1cc-99a07e68adbf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "StockItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aca93571-b16c-4e56-93b1-f34d808e4fb3", "AQAAAAIAAYagAAAAEBUKIAe4sArSKm2AK0Ho9dINR9sQuLbpuh6BbDQRNjGSkz2zQP8bZ0nOaibEaVqAMg==", "ccb91b6b-5faf-4add-91ee-97339822f4a4" });
        }
    }
}
