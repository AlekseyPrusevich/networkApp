using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class addTestDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTest",
                table: "Tests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTest",
                table: "Tests");
        }
    }
}
