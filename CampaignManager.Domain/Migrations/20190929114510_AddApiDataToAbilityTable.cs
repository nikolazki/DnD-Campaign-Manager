using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddApiDataToAbilityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiId",
                table: "Abilities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApiUrl",
                table: "Abilities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "Abilities");

            migrationBuilder.DropColumn(
                name: "ApiUrl",
                table: "Abilities");
        }
    }
}
