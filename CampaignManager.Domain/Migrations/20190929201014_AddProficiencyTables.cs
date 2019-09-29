using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddProficiencyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumProficiencyChoices",
                table: "Classes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProficiencyChoices",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    ProficiencyId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ProficiencyGivens",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    ProficiencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyGivens", x => new { x.ClassId, x.ProficiencyId });
                    table.ForeignKey(
                        name: "FK_ProficiencyGivens_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProficiencyGivens_Proficencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProficiencySavingThrows",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    AbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencySavingThrows", x => new { x.ClassId, x.AbilityId });
                    table.UniqueConstraint("AK_ProficiencySavingThrows_AbilityId_ClassId", x => new { x.AbilityId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_ProficiencySavingThrows_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProficiencySavingThrows_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProficiencyChoices_ProficiencyId",
                table: "ProficiencyChoices",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProficiencyGivens_ProficiencyId",
                table: "ProficiencyGivens",
                column: "ProficiencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProficiencyChoices");

            migrationBuilder.DropTable(
                name: "ProficiencyGivens");

            migrationBuilder.DropTable(
                name: "ProficiencySavingThrows");

            migrationBuilder.DropColumn(
                name: "NumProficiencyChoices",
                table: "Classes");
        }
    }
}
