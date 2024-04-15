using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfiedsDropMultiBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "HasMultiBuyDiscount",
                table: "StockItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e148e75-3678-4186-8429-587b5beb225c", "AQAAAAIAAYagAAAAEBQ9PFPHvxd2G1tBi/yP2ePNDFSvdKT2T31hLQL3YtmwHmMqUm18SRd0YVyjy7hlUg==", "9963d2c4-dd49-44b5-a45c-4debac85b84c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasMultiBuyDiscount",
                table: "StockItems",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MultiBuyDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MaxiumNumerOfItemsForOffer = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfItemsForOffer = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    OfferPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiBuyDiscounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "979123f9-e335-41c6-9091-3f9937c0a931", "AQAAAAIAAYagAAAAEO0phzvzI5aY4UpuLYisckUahmcxpUcmYjKFxpcCAT3sLUv1K+38h1r1JlNDEv4G7A==", "7e7d00d5-75ab-4530-a1cc-99a07e68adbf" });
        }
    }
}
