using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddMountsAndVehiclesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MountsAndVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    VehicleCategory = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    SpeedQuantity = table.Column<double>(nullable: false),
                    SpeedUnit = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApiId = table.Column<int>(nullable: false),
                    ApiUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountsAndVehicles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MountsAndVehicles");
        }
    }
}
