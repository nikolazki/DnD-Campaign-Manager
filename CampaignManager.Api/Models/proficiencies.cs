using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Api.Models
{
    public class proficiencies
    {
        public int index { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public List<object> classes { get; set; }
        public List<object> races { get; set; }
        public string url { get; set; }
    }
}
