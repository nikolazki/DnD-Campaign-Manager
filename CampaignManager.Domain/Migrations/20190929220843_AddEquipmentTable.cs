using Microsoft.EntityFrameworkCore.Migrations;

namespace CampaignManager.Domain.Migrations
{
    public partial class AddEquipmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponProperties_Weapons_WeaponId",
                table: "WeaponProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_DamageTypes_DamageTypeId",
                table: "Weapons");

            migrationBuilder.DropTable(
                name: "AdventuringGear");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "MountsAndVehicles");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "Equipment");

            migrationBuilder.RenameIndex(
                name: "IX_Weapons_DamageTypeId",
                table: "Equipment",
                newName: "IX_Equipment_DamageTypeId");

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Equipment",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "DiceValue",
                table: "Equipment",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DiceCount",
                table: "Equipment",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DamageTypeId",
                table: "Equipment",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GearCategory",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArmorCategory",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseArmorClass",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DexterityBonus",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxBonus",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinStrength",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StealthDisadvantage",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Equipment",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MountsAndVehicles_Description",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SpeedQuantity",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpeedUnit",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleCategory",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tool_Description",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToolCategory",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StartingEquipment",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartingEquipment", x => new { x.ClassId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_StartingEquipment_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_DamageTypes_DamageTypeId",
                table: "Equipment",
                column: "DamageTypeId",
                principalTable: "DamageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponProperties_Equipment_WeaponId",
                table: "WeaponProperties",
                column: "WeaponId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_DamageTypes_DamageTypeId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponProperties_Equipment_WeaponId",
                table: "WeaponProperties");

            migrationBuilder.DropTable(
                name: "StartingEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "GearCategory",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ArmorCategory",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "BaseArmorClass",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DexterityBonus",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "MaxBonus",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "MinStrength",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "StealthDisadvantage",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "MountsAndVehicles_Description",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "SpeedQuantity",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "SpeedUnit",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "VehicleCategory",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Tool_Description",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ToolCategory",
                table: "Equipment");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "Weapons");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_DamageTypeId",
                table: "Weapons",
                newName: "IX_Weapons_DamageTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "DiceValue",
                table: "Weapons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiceCount",
                table: "Weapons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DamageTypeId",
                table: "Weapons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Weapons",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdventuringGear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiId = table.Column<int>(type: "int", nullable: false),
                    ApiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdventuringGear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiId = table.Column<int>(type: "int", nullable: false),
                    ApiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArmorCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseArmorClass = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    DexterityBonus = table.Column<bool>(type: "bit", nullable: false),
                    MaxBonus = table.Column<int>(type: "int", nullable: true),
                    MinStrength = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StealthDisadvantage = table.Column<bool>(type: "bit", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MountsAndVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiId = table.Column<int>(type: "int", nullable: false),
                    ApiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeedQuantity = table.Column<double>(type: "float", nullable: true),
                    SpeedUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountsAndVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiId = table.Column<int>(type: "int", nullable: false),
                    ApiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponProperties_Weapons_WeaponId",
                table: "WeaponProperties",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_DamageTypes_DamageTypeId",
                table: "Weapons",
                column: "DamageTypeId",
                principalTable: "DamageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
