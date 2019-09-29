using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampaignManager.Domain
{
    public class ProficiencySavingThrow
    {
        [Key]
        public int ClassId { get; set; }
        public Class Class { get; set; }

        [Key]
        public int AbilityId { get; set; }
        public Ability Ability { get; set; }
    }
}
