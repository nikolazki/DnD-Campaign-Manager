using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
