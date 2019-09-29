using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class AdventuringGear : IEquipment
    {
        //-- Public Properties
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public string GearCategory { get; set; }
        public int Cost { get; set; } // in cp
        public double Weight { get; set; }

        /* Api Reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }
    }
}
