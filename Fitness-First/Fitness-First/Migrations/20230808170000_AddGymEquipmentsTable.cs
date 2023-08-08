using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness_First.Migrations
{
    public partial class AddGymEquipmentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "GymEquipments",
               columns: table => new
               {
                   EquipmentID = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   EquipmentName = table.Column<string>(nullable: true),
                   Quantity = table.Column<int>(nullable: true),
                   Availability = table.Column<string>(nullable: true),
                   EquipmentPicturePath = table.Column<string>(nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_GymEquipments", x => x.EquipmentID);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "GymEquipments");
        }
    }
}
