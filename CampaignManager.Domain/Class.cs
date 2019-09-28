using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Class
    {
        //-- Public Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitDice { get; set; }
        public int NumProficiencyChoices { get; set; }

        //-- Relationships
        public ICollection<Character> Characters { get; set; }
        
        /*public ICollection<Proficiency> ProficiencyChoices { get; set; }
        public ICollection<Proficiency> Proficiencies { get; set; }
        public ICollection<AbilityScore> SavingThrows { get; set; }
        public ICollection<StartingEquipment> StartingEquipment { get; set; }*/
    }
}
