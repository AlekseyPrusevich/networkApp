using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupToTestID_GroupInfo_GroupsInfoId",
                table: "GroupToTestID");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupToTestID_TestProp_TestPropId",
                table: "GroupToTestID");

            migrationBuilder.DropIndex(
                name: "IX_GroupToTestID_GroupsInfoId",
                table: "GroupToTestID");

            migrationBuilder.DropIndex(
                name: "IX_GroupToTestID_TestPropId",
                table: "GroupToTestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_GroupToTestID_GroupsInfoId",
                table: "GroupToTestID",
                column: "GroupsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToTestID_TestPropId",
                table: "GroupToTestID",
                column: "TestPropId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupToTestID_GroupInfo_GroupsInfoId",
                table: "GroupToTestID",
                column: "GroupsInfoId",
                principalTable: "GroupInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupToTestID_TestProp_TestPropId",
                table: "GroupToTestID",
                column: "TestPropId",
                principalTable: "TestProp",
                principalColumn: "TestPropId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
