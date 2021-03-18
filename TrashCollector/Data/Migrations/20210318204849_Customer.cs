using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cf3e74a-1b1b-43f6-b370-881b4746f4a2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "977a658f-773b-4e16-8136-53faf15aa480", "fb635265-9e4b-4ea3-a844-1e37169dcf94", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "977a658f-773b-4e16-8136-53faf15aa480");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cf3e74a-1b1b-43f6-b370-881b4746f4a2", "db9abf27-9639-405a-b009-c4e24ee55ba6", "Admin", "ADMIN" });
        }
    }
}
