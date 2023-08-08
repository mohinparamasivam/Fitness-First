using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness_First.Migrations
{
    public partial class AddPackageEnrollmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "PackageEnrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<int>(nullable: false),
                    MemberEmail = table.Column<int>(nullable: false),
                    PackageName = table.Column<string>(nullable: true),
                    PackagePrice = table.Column<double>(nullable: false),
                    InstructorName = table.Column<string>(nullable: true),
                    Session1 = table.Column<DateTime>(nullable: false),
                    Session2 = table.Column<DateTime>(nullable: false),
                    Session3 = table.Column<DateTime>(nullable: false),
                    Session4 = table.Column<DateTime>(nullable: false),
                    Session5 = table.Column<DateTime>(nullable: false),
                    Session6 = table.Column<DateTime>(nullable: false),
                    Session7 = table.Column<DateTime>(nullable: false),
                    Session8 = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageEnrollments", x => x.EnrollmentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymEquipments");

            migrationBuilder.DropTable(
                name: "PackageEnrollments");

            migrationBuilder.DropColumn(
                name: "MemberName",
                table: "AspNetUsers");
        }
    }
}
