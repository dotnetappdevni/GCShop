using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfileds6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarCode",
                table: "Tills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8c1f5ec-08d6-4506-aed9-f045c783d0bc", "AQAAAAIAAYagAAAAEAFUIE9sjGAJaUbs7EVo3r6NbYcZne37uFVIstjozEgTqhDtE5EOCKgCbzbD8fHrDw==", "92696e12-d582-4979-a9f3-3bf670aa1e13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "Tills");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a178dc2-5ad6-4ace-a9a9-6e0a5c723802", "AQAAAAIAAYagAAAAEFAf7cycOdysjuLIu265tgF8pBzwKN+HESN4OA1Ro0n3tfaXwB8lO/nA7JtaA6sNIA==", "472af0d2-6d5a-48eb-b6a6-0b5f7f44eeef" });
        }
    }
}
