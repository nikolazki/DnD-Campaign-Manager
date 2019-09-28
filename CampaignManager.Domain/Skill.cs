using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Skill
    {
        //-- Public Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //-- Relationships
        public int AbilityId { get; set; }
        public Ability AbilityS { get; set; }

    }
}
