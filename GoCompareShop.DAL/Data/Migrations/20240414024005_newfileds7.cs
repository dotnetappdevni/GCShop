using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCompareShop.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfileds7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562710e6-07a7-448d-8911-b02d0b8551ec", "AQAAAAIAAYagAAAAECDLE7kOJrVYlh/tLPRHz6NCgIWN0Jx8EN5en/+HPJ0KCn6Ijbxj/bimGjBj6PuYGg==", "fabc7401-ace5-415c-b1ed-aeb1bbcdb3f1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8c1f5ec-08d6-4506-aed9-f045c783d0bc", "AQAAAAIAAYagAAAAEAFUIE9sjGAJaUbs7EVo3r6NbYcZne37uFVIstjozEgTqhDtE5EOCKgCbzbD8fHrDw==", "92696e12-d582-4979-a9f3-3bf670aa1e13" });
        }
    }
}
