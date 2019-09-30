using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class ReaddProficiencyChoiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProficiencyChoices",
                columns: table => new
                {
                    ProficiencyChoiceGroupId = table.Column<int>(nullable: false),
                    ProficiencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyChoices", x => new { x.ProficiencyChoiceGroupId, x.ProficiencyId });
                    table.ForeignKey(
                        name: "FK_ProficiencyChoices_ProficiencyChoiceGroups_ProficiencyChoiceGroupId",
                        column: x => x.ProficiencyChoiceGroupId,
                        principalTable: "ProficiencyChoiceGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProficiencyChoices_Proficencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProficiencyChoices_ProficiencyId",
                table: "ProficiencyChoices",
                column: "ProficiencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProficiencyChoices");
        }
    }
}
