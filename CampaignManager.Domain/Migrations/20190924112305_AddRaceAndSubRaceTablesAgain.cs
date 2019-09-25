using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddRaceAndSubRaceTablesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_SubRace_SubRaceId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_SubRace_Race_RaceId",
                table: "SubRace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubRace",
                table: "SubRace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Race",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "SubRace",
                newName: "SubRaces");

            migrationBuilder.RenameTable(
                name: "Race",
                newName: "Races");

            migrationBuilder.RenameIndex(
                name: "IX_SubRace_RaceId",
                table: "SubRaces",
                newName: "IX_SubRaces_RaceId");

            migrationBuilder.AlterColumn<int>(
                name: "SubRaceId",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxHP",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "SubRaces",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Races",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubRaces",
                table: "SubRaces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Races",
                table: "Races",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_SubRaces_SubRaceId",
                table: "Characters",
                column: "SubRaceId",
                principalTable: "SubRaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubRaces_Races_RaceId",
                table: "SubRaces",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_SubRaces_SubRaceId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_SubRaces_Races_RaceId",
                table: "SubRaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubRaces",
                table: "SubRaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Races",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MaxHP",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "SubRaces",
                newName: "SubRace");

            migrationBuilder.RenameTable(
                name: "Races",
                newName: "Race");

            migrationBuilder.RenameIndex(
                name: "IX_SubRaces_RaceId",
                table: "SubRace",
                newName: "IX_SubRace_RaceId");

            migrationBuilder.AlterColumn<int>(
                name: "SubRaceId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SubRace",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Race",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubRace",
                table: "SubRace",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Race",
                table: "Race",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_SubRace_SubRaceId",
                table: "Characters",
                column: "SubRaceId",
                principalTable: "SubRace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubRace_Race_RaceId",
                table: "SubRace",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
