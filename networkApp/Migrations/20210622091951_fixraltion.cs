using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class fixraltion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupInfo_UserToTests_UserToTestsId",
                table: "GroupInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_TestProp_UserToTests_UserToTestsId",
                table: "TestProp");

            migrationBuilder.DropIndex(
                name: "IX_TestProp_UserToTestsId",
                table: "TestProp");

            migrationBuilder.DropIndex(
                name: "IX_GroupInfo_UserToTestsId",
                table: "GroupInfo");

            migrationBuilder.DropColumn(
                name: "UserToTestsId",
                table: "TestProp");

            migrationBuilder.DropColumn(
                name: "UserToTestsId",
                table: "GroupInfo");

            migrationBuilder.AddColumn<int>(
                name: "GroupsInfoId",
                table: "UserToTests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestPropId",
                table: "UserToTests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserToTests_GroupsInfoId",
                table: "UserToTests",
                column: "GroupsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToTests_TestPropId",
                table: "UserToTests",
                column: "TestPropId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserToTests_GroupInfo_GroupsInfoId",
                table: "UserToTests",
                column: "GroupsInfoId",
                principalTable: "GroupInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToTests_TestProp_TestPropId",
                table: "UserToTests",
                column: "TestPropId",
                principalTable: "TestProp",
                principalColumn: "TestPropId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserToTests_GroupInfo_GroupsInfoId",
                table: "UserToTests");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToTests_TestProp_TestPropId",
                table: "UserToTests");

            migrationBuilder.DropIndex(
                name: "IX_UserToTests_GroupsInfoId",
                table: "UserToTests");

            migrationBuilder.DropIndex(
                name: "IX_UserToTests_TestPropId",
                table: "UserToTests");

            migrationBuilder.DropColumn(
                name: "GroupsInfoId",
                table: "UserToTests");

            migrationBuilder.DropColumn(
                name: "TestPropId",
                table: "UserToTests");

            migrationBuilder.AddColumn<int>(
                name: "UserToTestsId",
                table: "TestProp",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserToTestsId",
                table: "GroupInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestProp_UserToTestsId",
                table: "TestProp",
                column: "UserToTestsId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInfo_UserToTestsId",
                table: "GroupInfo",
                column: "UserToTestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupInfo_UserToTests_UserToTestsId",
                table: "GroupInfo",
                column: "UserToTestsId",
                principalTable: "UserToTests",
                principalColumn: "UserToTestsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestProp_UserToTests_UserToTestsId",
                table: "TestProp",
                column: "UserToTestsId",
                principalTable: "UserToTests",
                principalColumn: "UserToTestsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
