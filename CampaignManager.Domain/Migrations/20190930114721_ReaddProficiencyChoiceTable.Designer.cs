﻿// <auto-generated />
using System;
using CampaignManager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampaignManager.Domain.Migrations
{
    [DbContext(typeof(AuthContext))]
    [Migration("20190930114721_ReaddProficiencyChoiceTable")]
    partial class ReaddProficiencyChoiceTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CampaignManager.Domain.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("CampaignManager.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CampaignManager.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("RaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CampaignManager.Domain.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitDie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("CampaignManager.Domain.DamageType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DamageTypes");
                });

            modelBuilder.Entity("CampaignManager.Domain.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Equipment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Equipment");
                });

            modelBuilder.Entity("CampaignManager.Domain.Proficiency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proficencies");
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencyChoice", b =>
                {
                    b.Property<int>("ProficiencyChoiceGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProficiencyId")
                        .HasColumnType("int");

                    b.HasKey("ProficiencyChoiceGroupId", "ProficiencyId");

                    b.HasIndex("ProficiencyId");

                    b.ToTable("ProficiencyChoices");
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencyChoiceGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("NumChoices")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("ProficiencyChoiceGroups");
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencyGiven", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("ProficiencyId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "ProficiencyId");

                    b.HasIndex("ProficiencyId");

                    b.ToTable("ProficiencyGivens");
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencySavingThrow", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "AbilityId");

                    b.HasAlternateKey("AbilityId", "ClassId");

                    b.ToTable("ProficiencySavingThrows");
                });

            modelBuilder.Entity("CampaignManager.Domain.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentRaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentRaceId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("CampaignManager.Domain.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CampaignManager.Domain.StartingEquipment", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("StartingEquipment");
                });

            modelBuilder.Entity("CampaignManager.Domain.WeaponProperty", b =>
                {
                    b.Property<int>("WeaponId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponPropertyTypeId")
                        .HasColumnType("int");

                    b.HasKey("WeaponId", "WeaponPropertyTypeId");

                    b.HasIndex("WeaponPropertyTypeId");

                    b.ToTable("WeaponProperties");
                });

            modelBuilder.Entity("CampaignManager.Domain.WeaponPropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeaponPropertyTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CampaignManager.Domain.AdventuringGear", b =>
                {
                    b.HasBaseType("CampaignManager.Domain.Equipment");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GearCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AdventuringGear");
                });

            modelBuilder.Entity("CampaignManager.Domain.Armor", b =>
                {
                    b.HasBaseType("CampaignManager.Domain.Equipment");

                    b.Property<string>("ArmorCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BaseArmorClass")
                        .HasColumnType("int");

                    b.Property<bool>("DexterityBonus")
                        .HasColumnType("bit");

                    b.Property<int?>("MaxBonus")
                        .HasColumnType("int");

                    b.Property<int?>("MinStrength")
                        .HasColumnType("int");

                    b.Property<bool?>("StealthDisadvantage")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Armor");
                });

            modelBuilder.Entity("CampaignManager.Domain.MountsAndVehicles", b =>
                {
                    b.HasBaseType("CampaignManager.Domain.Equipment");

                    b.Property<string>("Description")
                        .HasColumnName("MountsAndVehicles_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SpeedQuantity")
                        .HasColumnType("float");

                    b.Property<string>("SpeedUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MountsAndVehicles");
                });

            modelBuilder.Entity("CampaignManager.Domain.Tool", b =>
                {
                    b.HasBaseType("CampaignManager.Domain.Equipment");

                    b.Property<string>("Description")
                        .HasColumnName("Tool_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToolCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Tool");
                });

            modelBuilder.Entity("CampaignManager.Domain.Weapon", b =>
                {
                    b.HasBaseType("CampaignManager.Domain.Equipment");

                    b.Property<string>("CategoryRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DamageTypeId")
                        .HasColumnType("int");

                    b.Property<int>("DiceCount")
                        .HasColumnType("int");

                    b.Property<int>("DiceValue")
                        .HasColumnType("int");

                    b.Property<int?>("LongRange")
                        .HasColumnType("int");

                    b.Property<int?>("LongThrowRange")
                        .HasColumnType("int");

                    b.Property<int?>("NormalRange")
                        .HasColumnType("int");

                    b.Property<int?>("NormalThrowRange")
                        .HasColumnType("int");

                    b.Property<string>("WeaponCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponRange")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("DamageTypeId");

                    b.HasDiscriminator().HasValue("Weapon");
                });

            modelBuilder.Entity("CampaignManager.Domain.Character", b =>
                {
                    b.HasOne("CampaignManager.Domain.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.Race", "Race")
                        .WithMany("Characters")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.ApplicationUser", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencyChoice", b =>
                {
                    b.HasOne("CampaignManager.Domain.ProficiencyChoiceGroup", "ProficiencyChoiceGroup")
                        .WithMany()
                        .HasForeignKey("ProficiencyChoiceGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.Proficiency", "Proficiency")
                        .WithMany()
                        .HasForeignKey("ProficiencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencyChoiceGroup", b =>
                {
                    b.HasOne("CampaignManager.Domain.Class", "Class")
                        .WithMany("ProficiencyChoiceGroups")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencyGiven", b =>
                {
                    b.HasOne("CampaignManager.Domain.Class", "Class")
                        .WithMany("GivenProficiencies")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.Proficiency", "Proficiency")
                        .WithMany()
                        .HasForeignKey("ProficiencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.ProficiencySavingThrow", b =>
                {
                    b.HasOne("CampaignManager.Domain.Ability", "Ability")
                        .WithMany()
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.Class", "Class")
                        .WithMany("SavingThrowProficiencies")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.Race", b =>
                {
                    b.HasOne("CampaignManager.Domain.Race", "ParentRace")
                        .WithMany("ChildRaces")
                        .HasForeignKey("ParentRaceId");
                });

            modelBuilder.Entity("CampaignManager.Domain.Skill", b =>
                {
                    b.HasOne("CampaignManager.Domain.Ability", "Ability")
                        .WithMany("Skills")
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.StartingEquipment", b =>
                {
                    b.HasOne("CampaignManager.Domain.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.WeaponProperty", b =>
                {
                    b.HasOne("CampaignManager.Domain.Weapon", "Weapon")
                        .WithMany("WeaponProperties")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.WeaponPropertyType", "WeaponPropertyType")
                        .WithMany()
                        .HasForeignKey("WeaponPropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CampaignManager.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CampaignManager.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampaignManager.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CampaignManager.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CampaignManager.Domain.Weapon", b =>
                {
                    b.HasOne("CampaignManager.Domain.DamageType", "DamageType")
                        .WithMany()
                        .HasForeignKey("DamageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
