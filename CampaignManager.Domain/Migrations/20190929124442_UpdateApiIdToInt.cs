using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class UpdateApiIdToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApiId",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ApiId",
                table: "Abilities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "Skills");

            migrationBuilder.AlterColumn<string>(
                name: "ApiId",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
