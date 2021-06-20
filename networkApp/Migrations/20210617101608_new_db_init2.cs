using Microsoft.EntityFrameworkCore.Migrations;

namespace networkApp.Migrations
{
    public partial class new_db_init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserToTestsId",
                table: "GroupInfo",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserToTests",
                columns: table => new
                {
                    UserToTestsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToTests", x => x.UserToTestsId);
                });

            migrationBuilder.CreateTable(
                name: "TestProp",
                columns: table => new
                {
                    TestPropId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(nullable: true),
                    UserToTestsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestProp", x => x.TestPropId);
                    table.ForeignKey(
                        name: "FK_TestProp_UserToTests_UserToTestsId",
                        column: x => x.UserToTestsId,
                        principalTable: "UserToTests",
                        principalColumn: "UserToTestsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupInfo_UserToTestsId",
                table: "GroupInfo",
                column: "UserToTestsId");

            migrationBuilder.CreateIndex(
                name: "IX_TestProp_UserToTestsId",
                table: "TestProp",
                column: "UserToTestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupInfo_UserToTests_UserToTestsId",
                table: "GroupInfo",
                column: "UserToTestsId",
                principalTable: "UserToTests",
                principalColumn: "UserToTestsId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupInfo_UserToTests_UserToTestsId",
                table: "GroupInfo");

            migrationBuilder.DropTable(
                name: "TestProp");

            migrationBuilder.DropTable(
                name: "UserToTests");

            migrationBuilder.DropIndex(
                name: "IX_GroupInfo_UserToTestsId",
                table: "GroupInfo");

            migrationBuilder.DropColumn(
                name: "UserToTestsId",
                table: "GroupInfo");
        }
    }
}
