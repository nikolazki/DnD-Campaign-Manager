using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Tool : Equipment
    {
        //-- Public Properties
        public string ToolCategory { get; set; }
        public string Description { get; set; }

        public Tool()
        {
            EquipmentCategory = "Tools";
        }
    }
}
