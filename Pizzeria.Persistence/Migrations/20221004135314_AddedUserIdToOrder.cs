using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzeria.Persistence.Migrations
{
    public partial class AddedUserIdToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "039cb4ca-edd3-49a1-b0f6-a7d6496204d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a419fb8-2e2e-4169-bcc7-cd9a7a9a4b34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "776bc71e-a922-4a00-8a80-5b98286d7b06", "ba671cd5-b7f1-4b57-956a-56b6c2b1a517", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2755718-3ce0-4e7c-b8c1-4a7798db5c65", "ab6a9552-c68a-4e81-b8a3-7e2af1933990", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776bc71e-a922-4a00-8a80-5b98286d7b06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2755718-3ce0-4e7c-b8c1-4a7798db5c65");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "039cb4ca-edd3-49a1-b0f6-a7d6496204d1", "f386edc7-f19f-48b4-bdc4-d412a4156419", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a419fb8-2e2e-4169-bcc7-cd9a7a9a4b34", "763577d2-8687-485d-ac02-bc444422c6fa", "User", "USER" });
        }
    }
}
