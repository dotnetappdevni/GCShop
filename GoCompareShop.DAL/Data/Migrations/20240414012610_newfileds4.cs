using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfileds4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfItems",
                table: "MultiBuyDiscounts");

            migrationBuilder.AddColumn<decimal>(
                name: "MaxiumNumerOfItemsForOffer",
                table: "MultiBuyDiscounts",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NumberOfItemsForOffer",
                table: "MultiBuyDiscounts",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OfferPrice",
                table: "MultiBuyDiscounts",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3601e7b-9a19-4cce-a9b2-b92d05e8ed65", "AQAAAAIAAYagAAAAEONQoHdv7Sl7VCNtfbDDKJKOEeEiZKB7KAJi0SWyxsAqcjnY94UzeLnKu4M8jUzojA==", "19890f85-e989-4e11-af4e-64268fff7125" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxiumNumerOfItemsForOffer",
                table: "MultiBuyDiscounts");

            migrationBuilder.DropColumn(
                name: "NumberOfItemsForOffer",
                table: "MultiBuyDiscounts");

            migrationBuilder.DropColumn(
                name: "OfferPrice",
                table: "MultiBuyDiscounts");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfItems",
                table: "MultiBuyDiscounts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62efbaa9-4ee6-42d3-8511-ab466bbd15da", "AQAAAAIAAYagAAAAECrCUgY0M6/+CpCZ7wifd29/J4Jq1CqCwdNTyPYBGHl6wXM5lCIHcgcheqsp7aeb1A==", "98aa8e17-b99f-47cd-834d-580a6da59e1e" });
        }
    }
}
