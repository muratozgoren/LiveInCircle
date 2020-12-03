using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiveInCircle.DAL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "character varying(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(18)",
                oldMaxLength: 18);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Order",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Genre",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Artist",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Album",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "ActivationCode", "Address", "BirthDate", "CreatedDate", "Email", "FirstName", "IsActive", "LastName", "Password", "PhoneNumber", "Role" },
                values: new object[] { 1, new Guid("00000000-0000-0000-0000-000000000000"), "İstanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 23, 9, 54, 34, 242, DateTimeKind.Local).AddTicks(1478), "muratozgoren@icloud.com", "Murat", true, "Özgören", "123", null, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Album");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "character varying(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(18)",
                oldMaxLength: 18,
                oldNullable: true);
        }
    }
}
