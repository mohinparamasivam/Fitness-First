using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness_First.Migrations
{
    public partial class GymEquipmentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "GymPackage",
                columns: table => new
                {
                    PackageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(nullable: true),
                    PackagePrice = table.Column<float>(nullable: false),
                    TimeSlots = table.Column<DateTime>(nullable: false),
                    InstructorName = table.Column<string>(nullable: true),
                    PackagePicturePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymPackage", x => x.PackageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymPackage");

            migrationBuilder.CreateTable(
                name: "GymPackages",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackagePrice = table.Column<float>(type: "real", nullable: false),
                    TimeSlots = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymPackages", x => x.PackageID);
                });
        }
    }
}
