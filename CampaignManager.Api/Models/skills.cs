using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Api.Models
{
    public class skill_ability_score
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class skills
    {
        public int index { get; set; }
        public string name { get; set; }
        public string[] desc { get; set; }
        public skill_ability_score ability_score { get; set; }
        public string url { get; set; }
    }
}
