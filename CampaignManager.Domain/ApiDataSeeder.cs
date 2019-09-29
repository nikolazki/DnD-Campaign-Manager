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
                            Ability = context.Abilities.SingleOrDefault(a => a.ApiId == skill.index),
                            Name = skill.name,
                            Description = String.Join("\n", skill.desc)
                        });
                    }
                }
                context.Skills.AddRange(Skills);
                await context.SaveChangesAsync();
            }
            
        }
    }
}
