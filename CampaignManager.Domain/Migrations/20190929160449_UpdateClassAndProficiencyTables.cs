using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class UpdateClassAndProficiencyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HitDice",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "NumProficiencyChoices",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ApiId",
                table: "Proficencies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ApiUrl",
                table: "Proficencies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApiId",
                table: "Classes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ApiUrl",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HitDie",
                table: "Classes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "Proficencies");

            migrationBuilder.DropColumn(
                name: "ApiUrl",
                table: "Proficencies");

            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ApiUrl",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "HitDie",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "HitDice",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumProficiencyChoices",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
