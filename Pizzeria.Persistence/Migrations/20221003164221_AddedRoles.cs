using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzeria.Persistence.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "039cb4ca-edd3-49a1-b0f6-a7d6496204d1", "f386edc7-f19f-48b4-bdc4-d412a4156419", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a419fb8-2e2e-4169-bcc7-cd9a7a9a4b34", "763577d2-8687-485d-ac02-bc444422c6fa", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "039cb4ca-edd3-49a1-b0f6-a7d6496204d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a419fb8-2e2e-4169-bcc7-cd9a7a9a4b34");
        }
    }
}
