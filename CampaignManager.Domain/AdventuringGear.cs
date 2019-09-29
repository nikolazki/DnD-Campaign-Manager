using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class AdventuringGear : Equipment
    {
        //-- Public Properties
        /* Data we care about */
        public string GearCategory { get; set; }
        public string Description { get; set; }

        //-- Constructor
        public AdventuringGear()
        {
            _equipmentType = "Adventuring Gear";
        }
    }
}
