using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddApiDataToSkillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiUrl",
                table: "Skills",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiUrl",
                table: "Skills");
        }
    }
}
