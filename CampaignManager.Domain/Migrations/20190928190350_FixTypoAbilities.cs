using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class FixTypoAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Abilitiles_AbilityId",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abilitiles",
                table: "Abilitiles");

            migrationBuilder.RenameTable(
                name: "Abilitiles",
                newName: "Abilities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abilities",
                table: "Abilities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Abilities_AbilityId",
                table: "Skills",
                column: "AbilityId",
                principalTable: "Abilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Abilities_AbilityId",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abilities",
                table: "Abilities");

            migrationBuilder.RenameTable(
                name: "Abilities",
                newName: "Abilitiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abilitiles",
                table: "Abilitiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Abilitiles_AbilityId",
                table: "Skills",
                column: "AbilityId",
                principalTable: "Abilitiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
