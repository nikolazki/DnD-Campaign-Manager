using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class RemoveProficiencyChoiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProficiencyChoices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProficiencyChoices",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    ProficiencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyChoices", x => new { x.ClassId, x.ProficiencyId });
                    table.ForeignKey(
                        name: "FK_ProficiencyChoices_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
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
    }
}
