using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Ability
    {
        //-- Public Properties
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        /* Api reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }

        //-- Relationships
        public ICollection<Skill> Skills { get; set; }
    }
}
