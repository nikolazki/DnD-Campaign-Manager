using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CampaignManager.Api.Models;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace CampaignManager.Domain
{
    public static class ApiDataSeeder
    {

        /* Seed data from API (http://www.dnd5eapi.co) */
        public static async Task Seed(AuthContext context)
        {
            string contentRootPath = @"C:\progs\CampaignManager\CampaignManager.Api\Data";

            // Seed Ability Table
            if (!context.Abilities.Any())
            {
                List<Ability> Abilities = new List<Ability>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Ability-Scores.json"))
                {
                    string json = r.ReadToEnd();
                    List<ability_scores> abilities = JsonConvert.DeserializeObject<List<ability_scores>>(json);

                    foreach (var ability in abilities)
                    {
                        Abilities.Add(new Ability
                        {
                            ApiId = ability.index,
                            ApiUrl = ability.url,
                            Name = ability.name,
                            FullName = ability.full_name,
                            Description = String.Join("\\n", ability.desc)                              
                        });
                    }
                }
                context.Abilities.AddRange(Abilities);
                await context.SaveChangesAsync();
            }

            // Seed Skills Table
            if (!context.Skills.Any())
            {
                List<Skill> Skills = new List<Skill>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Skills.json"))
                {
                    string json = r.ReadToEnd();
                    List<skills> skills = JsonConvert.DeserializeObject<List<skills>>(json);

                    foreach (var skill in skills)
                    {
                        Skills.Add(new Skill
                        {
                            ApiId = skill.index,
                            ApiUrl = skill.url,
                            Ability = context.Abilities.SingleOrDefault(a => a.ApiUrl == skill.ability_score.url),
                            Name = skill.name,
                            Description = String.Join("\\n", skill.desc)
                        });
                    }
                }
                context.Skills.AddRange(Skills);
                await context.SaveChangesAsync();
            }

            // Seed DamageType Table
            if (!context.DamageTypes.Any())
            {
                List<DamageType> DamageTypes = new List<DamageType>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Damage-Types.json"))
                {
                    string json = r.ReadToEnd();
                    List<damage_types> damageTypes = JsonConvert.DeserializeObject<List<damage_types>>(json);

                    foreach (var damageType in damageTypes)
                    {
                        DamageTypes.Add(new DamageType
                        {
                            ApiId = damageType.index,
                            ApiUrl = damageType.url,
                            Description = String.Join("\\n", damageType.desc),
                            Name = damageType.name
                        });
                    }
                }
                context.DamageTypes.AddRange(DamageTypes);
                await context.SaveChangesAsync();
            }

            // Seed WeaponPropertyType Table
            if (!context.WeaponPropertyTypes.Any())
            {
                List<WeaponPropertyType> WeaponPropertyTypes = new List<WeaponPropertyType>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Weapon-Properties.json"))
                {
                    string json = r.ReadToEnd();
                    List<weapon_properties> weaponProperties = JsonConvert.DeserializeObject<List<weapon_properties>>(json);

                    foreach (var weaponProperty in weaponProperties)
                    {
                        WeaponPropertyTypes.Add(new WeaponPropertyType
                        {
                            ApiId = weaponProperty.index,
                            ApiUrl = weaponProperty.url,
                            Description = String.Join("\\n", weaponProperty.desc),
                            Name = weaponProperty.name
                        });
                    }
                }
                context.WeaponPropertyTypes.AddRange(WeaponPropertyTypes);
                await context.SaveChangesAsync();
            }

            // Seed Weapons and WeaponProperties Tables
            if(!context.Weapons.Any())
            {
                List<Weapon> Weapons = new List<Weapon>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Equipment.json"))
                {
                    string json = r.ReadToEnd();
                    List<equipment> weapons = JsonConvert.DeserializeObject<List<equipment>>(json).Where(e => e.equipment_category == "Weapon").ToList();

                    foreach (var weapon in weapons)
                    {
                        List<WeaponProperty> weaponProperties = new List<WeaponProperty>();
                        foreach (var weaponProperty in weapon.properties)
                        {
                            weaponProperties.Add(new WeaponProperty
                            {
                                WeaponPropertyType = context.WeaponPropertyTypes.SingleOrDefault(w => w.ApiUrl == weaponProperty.url)
                            });
                        }

                        Weapon newWeapon = new Weapon();
                        newWeapon.ApiId = weapon.index;
                        newWeapon.ApiUrl = weapon.url;
                        newWeapon.CategoryRange = weapon.category_range;
                        newWeapon.Cost = CalculateCost(weapon.cost.quantity, weapon.cost.unit);
                        newWeapon.DamageType = context.DamageTypes.SingleOrDefault(d => d.ApiUrl == weapon.damage.damage_type.url);
                        newWeapon.DiceCount = weapon.damage.dice_count;
                        newWeapon.DiceValue = weapon.damage.dice_value;
                        newWeapon.LongRange = weapon.range.@long;
                        newWeapon.Name = weapon.name;
                        newWeapon.NormalRange = weapon.range.normal;
                        newWeapon.WeaponProperties = weaponProperties;
                        newWeapon.WeaponCategory = weapon.weapon_category;
                        newWeapon.WeaponRange = weapon.weapon_range;
                        newWeapon.Weight = weapon.weight;

                        if (weapon.throw_range != null)
                        {
                            newWeapon.LongThrowRange = weapon.throw_range.@long;
                            newWeapon.NormalThrowRange = weapon.throw_range.normal;
                        }

                        Weapons.Add(newWeapon);
                    }
                }
                context.Weapons.AddRange(Weapons);
                await context.SaveChangesAsync();

            }

            // Seed Armor Table
            if (!context.Armor.Any())
            {
                List<Armor> Armor = new List<Armor>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Equipment.json"))
                {
                    string json = r.ReadToEnd();
                    List<equipment> armors = JsonConvert.DeserializeObject<List<equipment>>(json).Where(e => e.equipment_category == "Armor").ToList();

                    foreach (var armor in armors)
                    {
                        Armor.Add(new Domain.Armor
                        {
                            ApiId = armor.index,
                            ApiUrl = armor.url,
                            ArmorCategory = armor.armor_category,
                            BaseArmorClass = armor.armor_class.@base,
                            Cost = CalculateCost(armor.cost.quantity, armor.cost.unit),
                            DexterityBonus = armor.armor_class.dex_bonus,
                            MaxBonus = armor.armor_class.max_bonus,
                            MinStrength = armor.str_minimum,
                            Name = armor.name,
                            StealthDisadvantage = armor.stealth_disadvantage,
                            Weight = armor.weight
                        });
                    }
                }
                context.Armor.AddRange(Armor);
                await context.SaveChangesAsync();

            }

            // Seed AdventuringGear Table
            if (!context.AdventuringGear.Any())
            {
                List<AdventuringGear> Gear = new List<AdventuringGear>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Equipment.json"))
                {
                    string json = r.ReadToEnd();
                    List<equipment> adventuringGear = JsonConvert.DeserializeObject<List<equipment>>(json).Where(e => e.equipment_category == "Adventuring Gear").ToList();

                    foreach (var gear in adventuringGear)
                    {
                        string desc = null;
                        if (gear.desc != null)
                            desc = String.Join("\\n", gear.desc);

                        Gear.Add(new AdventuringGear
                        {
                            ApiId = gear.index,
                            ApiUrl = gear.url,
                            Cost = CalculateCost(gear.cost.quantity, gear.cost.unit),
                            GearCategory = gear.gear_category,
                            Name = gear.name,
                            Weight = gear.weight,
                            Description = desc
                        });
                    }
                }
                context.AdventuringGear.AddRange(Gear);
                await context.SaveChangesAsync();
            }

            // Seed Tools Table
            if (!context.Tools.Any())
            {
                List<Tool> Tools = new List<Tool>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Equipment.json"))
                {
                    string json = r.ReadToEnd();
                    List<equipment> tools = JsonConvert.DeserializeObject<List<equipment>>(json).Where(e => e.equipment_category == "Tools").ToList();

                    foreach (var tool in tools)
                    {
                        Tools.Add(new Tool
                        {
                            ApiId = tool.index,
                            ApiUrl = tool.url,
                            Cost = CalculateCost(tool.cost.quantity, tool.cost.unit),
                            Description = String.Join("\\n", tool.desc),
                            Name = tool.name,
                            ToolCategory = tool.tool_category,
                            Weight = tool.weight
                        });
                    }
                }
                context.Tools.AddRange(Tools);
                await context.SaveChangesAsync();
            }

            // Seed MountsAndVehicles Table
            if (!context.MountsAndVehicles.Any())
            {
                List<MountsAndVehicles> MountsAndVehicles = new List<MountsAndVehicles>();
                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Equipment.json"))
                {
                    string json = r.ReadToEnd();
                    List<equipment> mountsAndVehicles = JsonConvert.DeserializeObject<List<equipment>>(json).Where(e => e.equipment_category == "Mounts and Vehicles").ToList();

                    foreach (var mountOrVehicle in mountsAndVehicles)
                    {
                        MountsAndVehicles newMorV = new MountsAndVehicles();

                        newMorV.ApiId = mountOrVehicle.index;
                        newMorV.ApiUrl = mountOrVehicle.url;
                        newMorV.Cost = CalculateCost(mountOrVehicle.cost.quantity, mountOrVehicle.cost.unit);

                        if (mountOrVehicle.desc != null)
                            newMorV.Description = String.Join("\\n", mountOrVehicle.desc);

                        newMorV.Name = mountOrVehicle.name;
                        
                        if (mountOrVehicle.speed != null)
                        {
                            newMorV.SpeedQuantity = mountOrVehicle.speed.quantity;
                            newMorV.SpeedUnit = mountOrVehicle.speed.unit;
                        }

                        newMorV.VehicleCategory = mountOrVehicle.vehicle_category;

                        if (mountOrVehicle.weight != null)
                            newMorV.Weight = mountOrVehicle.weight;

                        MountsAndVehicles.Add(newMorV);
                    }
                }
                context.MountsAndVehicles.AddRange(MountsAndVehicles);
                await context.SaveChangesAsync();
            }

            // Seed Proficiencies
            if (!context.Proficencies.Any())
            {
                List<Proficiency> Proficiencies = new List<Proficiency>();

                using (StreamReader r = new StreamReader(contentRootPath + @"\5e-SRD-Proficiencies.json"))
                {
                    string json = r.ReadToEnd();
                    List <proficiencies> proficiencies = JsonConvert.DeserializeObject<List<proficiencies>>(json);

                    foreach (var proficiency in proficiencies)
                    {
                        Proficiencies.Add(new Proficiency
                        {
                            ApiId = proficiency.index,
                            ApiUrl = proficiency.url,
                            Name = proficiency.name,
                            Type = proficiency.type
                        });
                    }
                }
                context.Proficencies.AddRange(Proficiencies);
                await context.SaveChangesAsync();
            }

            // Seed Classes, ProficiencyChoices, ProficienciesGiven, SavingThrows, Starting Equipment


        }

        private static int CalculateCost(int quantity, string unit)
        {
            switch(unit)
            {
                case "cp":
                    return quantity;
                case "sp":
                    return quantity * 10;
                case "gp":
                    return quantity * 100;
                case "pp":
                    return quantity * 1000;
                default:
                    return 0;
            }
        }
    }
}
