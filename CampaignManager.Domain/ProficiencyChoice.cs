using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampaignManager.Domain
{
    public class ProficiencyChoice
    {
        [Key]
        public int ProficiencyChoiceGroupId { get; set; }
        public ProficiencyChoiceGroup ProficiencyChoiceGroup { get; set; }
        [Key]
        public int ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; }
    }
}
