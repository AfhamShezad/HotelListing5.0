using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing5._0.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b26b835c-8624-4fd4-be53-7659567c97a4", "ccda8f40-6200-4d38-99dd-3cfdbe5cd969", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34004fcf-38ee-4f1a-8181-4703e6be8d9e", "f0d69976-d31c-4f0e-badb-242d8a7977fb", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34004fcf-38ee-4f1a-8181-4703e6be8d9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b26b835c-8624-4fd4-be53-7659567c97a4");
        }
    }
}
