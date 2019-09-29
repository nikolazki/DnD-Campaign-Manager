using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddSomeRelationshipsToClassTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Proficencies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId1",
                table: "Proficencies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Abilities",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proficencies_ClassId",
                table: "Proficencies",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Proficencies_ClassId1",
                table: "Proficencies",
                column: "ClassId1");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_ClassId",
                table: "Abilities",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abilities_Classes_ClassId",
                table: "Abilities",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilities_Classes_ClassId",
                table: "Abilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Proficencies_Classes_ClassId",
                table: "Proficencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Proficencies_Classes_ClassId1",
                table: "Proficencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficencies_ClassId",
                table: "Proficencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficencies_ClassId1",
                table: "Proficencies");

            migrationBuilder.DropIndex(
                name: "IX_Abilities_ClassId",
                table: "Abilities");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Proficencies");

            migrationBuilder.DropColumn(
                name: "ClassId1",
                table: "Proficencies");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Abilities");
        }
    }
}
