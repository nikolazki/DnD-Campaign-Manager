using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Class
    {
        //-- Public Properties
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitDie { get; set; }

        /* Api Reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }
       
    }
}
