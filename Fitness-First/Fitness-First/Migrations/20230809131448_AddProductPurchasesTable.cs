using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Fitness_First.Migrations
{
    public partial class AddProductPurchasesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPurchases",
                columns: table => new
                {
                    PurchaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductType = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    PurchasedBy = table.Column<string>(nullable: true),
                    PurchaseTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPurchases", x => x.PurchaseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPurchases");
        }
    }
}
