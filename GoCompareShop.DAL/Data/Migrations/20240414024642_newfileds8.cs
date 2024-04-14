using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfileds8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aca93571-b16c-4e56-93b1-f34d808e4fb3", "AQAAAAIAAYagAAAAEBUKIAe4sArSKm2AK0Ho9dINR9sQuLbpuh6BbDQRNjGSkz2zQP8bZ0nOaibEaVqAMg==", "ccb91b6b-5faf-4add-91ee-97339822f4a4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562710e6-07a7-448d-8911-b02d0b8551ec", "AQAAAAIAAYagAAAAECDLE7kOJrVYlh/tLPRHz6NCgIWN0Jx8EN5en/+HPJ0KCn6Ijbxj/bimGjBj6PuYGg==", "fabc7401-ace5-415c-b1ed-aeb1bbcdb3f1" });
        }
    }
}
