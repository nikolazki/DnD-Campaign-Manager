using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddWeaponData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartingEquipment");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApiId = table.Column<int>(nullable: false),
                    ApiUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponPropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApiId = table.Column<int>(nullable: false),
                    ApiUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponPropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    WeaponCategory = table.Column<string>(nullable: true),
                    WeaponRange = table.Column<string>(nullable: true),
                    CategoryRange = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    DiceCount = table.Column<int>(nullable: false),
                    DiceValue = table.Column<int>(nullable: false),
                    NormalRange = table.Column<int>(nullable: true),
                    LongRange = table.Column<int>(nullable: true),
                    NormalThrowRange = table.Column<int>(nullable: true),
                    LongThrowRange = table.Column<int>(nullable: true),
                    ApiId = table.Column<int>(nullable: false),
                    ApiUrl = table.Column<string>(nullable: true),
                    DamageTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponProperties",
                columns: table => new
                {
                    WeaponId = table.Column<int>(nullable: false),
                    WeaponPropertyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponProperties", x => new { x.WeaponId, x.WeaponPropertyTypeId });
                    table.ForeignKey(
                        name: "FK_WeaponProperties_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponProperties_WeaponPropertyTypes_WeaponPropertyTypeId",
                        column: x => x.WeaponPropertyTypeId,
                        principalTable: "WeaponPropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponProperties_WeaponPropertyTypeId",
                table: "WeaponProperties",
                column: "WeaponPropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_DamageTypeId",
                table: "Weapons",
                column: "DamageTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponProperties");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "WeaponPropertyTypes");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StartingEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartingEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartingEquipment_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StartingEquipment_EquipmentId",
                table: "StartingEquipment",
                column: "EquipmentId");
        }
    }
}
