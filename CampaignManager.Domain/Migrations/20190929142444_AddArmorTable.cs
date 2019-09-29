using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddArmorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ArmorCategory = table.Column<string>(nullable: true),
                    BaseArmorClass = table.Column<int>(nullable: false),
                    DexterityBonus = table.Column<bool>(nullable: false),
                    MaxBonus = table.Column<int>(nullable: false),
                    MinStrength = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    StealthDisadvantage = table.Column<bool>(nullable: false),
                    ApiId = table.Column<int>(nullable: false),
                    ApiUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armor");
        }
    }
}
