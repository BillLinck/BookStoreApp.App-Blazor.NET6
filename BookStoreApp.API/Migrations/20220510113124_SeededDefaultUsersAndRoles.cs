using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "016445f0-4296-4829-b176-4a9450e78a24", "8280ab8c-a3fb-4f7f-bf21-07e61d81be11", "User", "USER" },
                    { "4602e62a-3eea-4f48-9850-aa57245b273d", "b48edadc-1ab2-492f-844b-001ff71aee66", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16fd18a9-ec27-49cb-a029-1a6bd75e7c59", 0, "b17638c7-4740-4716-98ad-2bf82bd1189d", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEIoV70TklYfMgYX2lQ+xhgDQWpRiFxU5JoRKEgO/2KtmLZ/X/vdMEvrtF57Hg+1orA==", null, false, "310e1365-c0c0-4458-8056-bb91941f6fa8", false, "admin@bookstore.com" },
                    { "96f01530-e192-49ad-b6f4-97514f576cf4", 0, "40ec8360-4080-4d92-9991-7cac7bed7802", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEBlpfcdUVkhy6+WOGRdoNAOxD83FkZHM4ak8+Yfp5I9VuzSZLKlFsaZ0pLIFwjCQkQ==", null, false, "fc48a4a9-626d-41c6-b1a0-5c5704e1cd6e", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4602e62a-3eea-4f48-9850-aa57245b273d", "16fd18a9-ec27-49cb-a029-1a6bd75e7c59" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "016445f0-4296-4829-b176-4a9450e78a24", "96f01530-e192-49ad-b6f4-97514f576cf4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4602e62a-3eea-4f48-9850-aa57245b273d", "16fd18a9-ec27-49cb-a029-1a6bd75e7c59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "016445f0-4296-4829-b176-4a9450e78a24", "96f01530-e192-49ad-b6f4-97514f576cf4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016445f0-4296-4829-b176-4a9450e78a24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4602e62a-3eea-4f48-9850-aa57245b273d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16fd18a9-ec27-49cb-a029-1a6bd75e7c59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f01530-e192-49ad-b6f4-97514f576cf4");
        }
    }
}
