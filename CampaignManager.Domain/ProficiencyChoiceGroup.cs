using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class ProficiencyChoiceGroup
    {
        public int Id { get; set; }
        public int NumChoices { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }
        ICollection<Proficiency> Proficiencies { get; set; }
    }
}
 