using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newtablepricelist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Availability = table.Column<int>(type: "int", nullable: true),
                    TaxCodeId = table.Column<int>(type: "int", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    DiscountGroupId = table.Column<int>(type: "int", nullable: true),
                    Uom = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    MinimumOrderQuantity = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    MaximumOrderQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceLists", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "018a918c-60b5-4ca9-a8fa-ff1e28361678", "AQAAAAIAAYagAAAAELChQvLF7jePOeQMxinVQCNr3lyfsRsSd+ZjQ/+UjCay2+IthKAX0jQYvQXo/NG7Sw==", "0d057d37-5663-4b9a-b79e-ab2a832823c3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
