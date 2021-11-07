using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupInfoId",
                table: "GroupToTestID",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupToTestID_GroupInfoId",
                table: "GroupToTestID",
                column: "GroupInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToTestID_TestPropId",
                table: "GroupToTestID",
                column: "TestPropId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupToTestID_GroupInfo_GroupInfoId",
                table: "GroupToTestID",
                column: "GroupInfoId",
                principalTable: "GroupInfo",
                principalColumn: "GroupInfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupToTestID_TestProp_TestPropId",
                table: "GroupToTestID",
                column: "TestPropId",
                principalTable: "TestProp",
                principalColumn: "TestPropId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupToTestID_GroupInfo_GroupInfoId",
                table: "GroupToTestID");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupToTestID_TestProp_TestPropId",
                table: "GroupToTestID");

            migrationBuilder.DropIndex(
                name: "IX_GroupToTestID_GroupInfoId",
                table: "GroupToTestID");

            migrationBuilder.DropIndex(
                name: "IX_GroupToTestID_TestPropId",
                table: "GroupToTestID");

            migrationBuilder.DropColumn(
                name: "GroupInfoId",
                table: "GroupToTestID");
        }
    }
}
