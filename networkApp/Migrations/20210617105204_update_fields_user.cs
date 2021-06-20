using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class update_fields_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_GroupInfo_GroupInfoId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "GroupInfoId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_GroupInfo_GroupInfoId",
                table: "AspNetUsers",
                column: "GroupInfoId",
                principalTable: "GroupInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_GroupInfo_GroupInfoId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "GroupInfoId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_GroupInfo_GroupInfoId",
                table: "AspNetUsers",
                column: "GroupInfoId",
                principalTable: "GroupInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
