using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CampaignManager.Domain
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<AdventuringGear> AdventuringGear { get; set; }
        public DbSet<Armor> Armor { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<DamageType> DamageTypes { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<MountsAndVehicles> MountsAndVehicles { get; set; }
        public DbSet<Proficiency> Proficencies { get; set; }
        public DbSet<ProficiencyChoice> ProficiencyChoices { get; set; }
        public DbSet<ProficiencyChoiceGroup> ProficiencyChoiceGroups { get; set; }
        public DbSet<ProficiencyGiven> ProficiencyGivens { get; set; }
        public DbSet<ProficiencySavingThrow> ProficiencySavingThrows { get; set; }
        public DbSet<Race> Races   { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<StartingEquipment> StartingEquipment { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<WeaponProperty> WeaponProperties { get; set; }
        public DbSet<WeaponPropertyType> WeaponPropertyTypes { get; set; }
        public DbSet<Weapon> Weapons { get; set; }


        public AuthContext(DbContextOptions<AuthContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<WeaponProperty>()
                .HasKey(w => new { w.WeaponId, w.WeaponPropertyTypeId});

            builder.Entity<ProficiencyChoice>()
                .HasKey(p => new { p.ClassId, p.ProficiencyId });

            builder.Entity<ProficiencyGiven>()
                .HasKey(p => new { p.ClassId, p.ProficiencyId });

            builder.Entity<ProficiencySavingThrow>()
                .HasKey(p => new { p.ClassId, p.AbilityId });

            builder.Entity<StartingEquipment>()
                .HasKey(p => new { p.ClassId, p.EquipmentId });
        }
    }
}
