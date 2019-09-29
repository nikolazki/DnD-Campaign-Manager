using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampaignManager.Domain
{
    public class ProficiencyGiven
    {
        [Key]
        public int ClassId { get; set; }
        public Class Class { get; set; }
        [Key]
        public int ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; }
    }
}
