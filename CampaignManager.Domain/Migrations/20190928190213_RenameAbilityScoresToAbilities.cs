using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class RenameAbilityScoresToAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_AbilityScores_AbilityScoreId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "AbilityScores");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AbilityScoreId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AbilityScoreId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "AbilityId",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Abilitiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilitiles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AbilityId",
                table: "Skills",
                column: "AbilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Abilitiles_AbilityId",
                table: "Skills",
                column: "AbilityId",
                principalTable: "Abilitiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Abilitiles_AbilityId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "Abilitiles");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AbilityId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AbilityId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "AbilityScoreId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AbilityScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AbilityScoreId",
                table: "Skills",
                column: "AbilityScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_AbilityScores_AbilityScoreId",
                table: "Skills",
                column: "AbilityScoreId",
                principalTable: "AbilityScores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
