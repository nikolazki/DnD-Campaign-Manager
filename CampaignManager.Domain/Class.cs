using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Class
    {
        //-- Public Properties
        public int Id { get; set; }
        public string Name { get; set; }

        //-- Relationships
        public ICollection<Character> Characters { get; set; }
    }
}
