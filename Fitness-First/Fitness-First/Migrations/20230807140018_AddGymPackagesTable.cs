using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness_First.Migrations
{
    public partial class AddGymPackagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "GymPackages",
                columns: table => new
                {
                    PackageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(nullable: true),
                    PackagePrice = table.Column<double>(nullable: false),
                    Session1 = table.Column<DateTime>(nullable: false),
                    Session2 = table.Column<DateTime>(nullable: false),
                    Session3 = table.Column<DateTime>(nullable: false),
                    Session4 = table.Column<DateTime>(nullable: false),
                    Session5 = table.Column<DateTime>(nullable: false),
                    Session6 = table.Column<DateTime>(nullable: false),
                    Session7 = table.Column<DateTime>(nullable: false),
                    Session8 = table.Column<DateTime>(nullable: false),
                    InstructorName = table.Column<string>(nullable: true),
                    PackagePicturePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymPackages", x => x.PackageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymPackages");

            
        }
    }
}
