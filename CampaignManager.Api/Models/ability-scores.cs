using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Api.Models
{
    public class ability_score_skill
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class ability_scores
    {
        public int index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string[] desc { get; set; }
        public ability_score_skill[] skills { get; set; }
        public string url { get; set; }
    }
}
