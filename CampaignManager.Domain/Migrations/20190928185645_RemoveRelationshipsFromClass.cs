using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class RemoveRelationshipsFromClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbilityScores_Classes_ClassId",
                table: "AbilityScores");

            migrationBuilder.DropForeignKey(
                name: "FK_Proficencies_Classes_ClassId",
                table: "Proficencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Proficencies_Classes_ClassId1",
                table: "Proficencies");

            migrationBuilder.DropForeignKey(
                name: "FK_StartingEquipment_Classes_ClassId",
                table: "StartingEquipment");

            migrationBuilder.DropIndex(
                name: "IX_StartingEquipment_ClassId",
                table: "StartingEquipment");

            migrationBuilder.DropIndex(
                name: "IX_Proficencies_ClassId",
                table: "Proficencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficencies_ClassId1",
                table: "Proficencies");

            migrationBuilder.DropIndex(
                name: "IX_AbilityScores_ClassId",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "StartingEquipment");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Proficencies");

            migrationBuilder.DropColumn(
                name: "ClassId1",
                table: "Proficencies");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AbilityScores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "StartingEquipment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Proficencies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId1",
                table: "Proficencies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "AbilityScores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StartingEquipment_ClassId",
                table: "StartingEquipment",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Proficencies_ClassId",
                table: "Proficencies",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Proficencies_ClassId1",
                table: "Proficencies",
                column: "ClassId1");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScores_ClassId",
                table: "AbilityScores",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbilityScores_Classes_ClassId",
                table: "AbilityScores",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proficencies_Classes_ClassId",
                table: "Proficencies",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proficencies_Classes_ClassId1",
                table: "Proficencies",
                column: "ClassId1",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StartingEquipment_Classes_ClassId",
                table: "StartingEquipment",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
