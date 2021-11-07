using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class update_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserToTests");

            migrationBuilder.CreateTable(
                name: "GroupToTestID",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupsInfoId = table.Column<int>(nullable: false),
                    TestPropId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupToTestID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GroupToTestID_GroupInfo_GroupsInfoId",
                        column: x => x.GroupsInfoId,
                        principalTable: "GroupInfo",
                        principalColumn: "GroupInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupToTestID_TestProp_TestPropId",
                        column: x => x.TestPropId,
                        principalTable: "TestProp",
                        principalColumn: "TestPropId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupToTestID_GroupsInfoId",
                table: "GroupToTestID",
                column: "GroupsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToTestID_TestPropId",
                table: "GroupToTestID",
                column: "TestPropId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupToTestID");

            migrationBuilder.CreateTable(
                name: "UserToTests",
                columns: table => new
                {
                    UserToTestsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupsInfoId = table.Column<int>(type: "int", nullable: false),
                    TestPropId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToTests", x => x.UserToTestsId);
                    table.ForeignKey(
                        name: "FK_UserToTests_GroupInfo_GroupsInfoId",
                        column: x => x.GroupsInfoId,
                        principalTable: "GroupInfo",
                        principalColumn: "GroupInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToTests_TestProp_TestPropId",
                        column: x => x.TestPropId,
                        principalTable: "TestProp",
                        principalColumn: "TestPropId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserToTests_GroupsInfoId",
                table: "UserToTests",
                column: "GroupsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToTests_TestPropId",
                table: "UserToTests",
                column: "TestPropId");
        }
    }
}
