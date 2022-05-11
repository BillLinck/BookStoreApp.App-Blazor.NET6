using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class FixedAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016445f0-4296-4829-b176-4a9450e78a24",
                column: "ConcurrencyStamp",
                value: "7f17ad20-e9f3-49d9-a5d0-fb44984e8a9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4602e62a-3eea-4f48-9850-aa57245b273d",
                column: "ConcurrencyStamp",
                value: "d7699233-6873-4610-994d-32ae02c09a08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16fd18a9-ec27-49cb-a029-1a6bd75e7c59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deeb9598-9f12-4b3e-b811-37cef22629a7", "AQAAAAEAACcQAAAAEIRkDLwJCKc7sYU++h1Ov83sOxaiKgUoEaQt1AaKgltLI4g8Ksnkm51HoUIFSsXtIg==", "10166854-49b3-478e-8d2d-d5a2a900160f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f01530-e192-49ad-b6f4-97514f576cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84cf6da5-ed20-4b56-adcd-d4d6c4115681", "AQAAAAEAACcQAAAAEFHvIEXaLxHOFBjzgTyqd7XG3Nh3bconD5YofuUyZElYtBeEW8JEh7/2MGEPiYrdkA==", "d4936505-d209-4afc-9404-008cef8eb712" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "LastName",
                table: "Authors",
                type: "varbinary(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Bio",
                table: "Authors",
                type: "varbinary(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016445f0-4296-4829-b176-4a9450e78a24",
                column: "ConcurrencyStamp",
                value: "8280ab8c-a3fb-4f7f-bf21-07e61d81be11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4602e62a-3eea-4f48-9850-aa57245b273d",
                column: "ConcurrencyStamp",
                value: "b48edadc-1ab2-492f-844b-001ff71aee66");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16fd18a9-ec27-49cb-a029-1a6bd75e7c59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17638c7-4740-4716-98ad-2bf82bd1189d", "AQAAAAEAACcQAAAAEIoV70TklYfMgYX2lQ+xhgDQWpRiFxU5JoRKEgO/2KtmLZ/X/vdMEvrtF57Hg+1orA==", "310e1365-c0c0-4458-8056-bb91941f6fa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f01530-e192-49ad-b6f4-97514f576cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40ec8360-4080-4d92-9991-7cac7bed7802", "AQAAAAEAACcQAAAAEBlpfcdUVkhy6+WOGRdoNAOxD83FkZHM4ak8+Yfp5I9VuzSZLKlFsaZ0pLIFwjCQkQ==", "fc48a4a9-626d-41c6-b1a0-5c5704e1cd6e" });
        }
    }
}
