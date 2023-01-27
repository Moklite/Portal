using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.Migrations
{
    public partial class index : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BizUnitInformedMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BizUnitInvolvedMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BizUnitPositiveCulture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BizUnitOnTheJobTraining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BizUnitAssignedWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BizUnitImprovementIdeas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyJobValuableWorkExp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyJobSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyJobManageableWorkload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyJobClearlyDefined = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyJobWorkLifeHarmony = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PMAccessible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PMRespectsMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PMAppreciates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isPMRoleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isPMSupportive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isPMResilient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPDQualityDiscussion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPDWellPrepared = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPDFeedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPDAlign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMyCareerSatisfactory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMyCareerExpectationMet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMyCareerpromotion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMyCompensationPeers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMyCompensationMarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMyCompensationPerf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ServiceLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovingTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlumniHomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
