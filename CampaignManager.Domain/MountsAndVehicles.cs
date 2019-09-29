using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class MountsAndVehicles : IEquipment
    {
        //-- Public Properties
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleCategory { get; set; }
        public int Cost { get; set; } // in cp
        public double? SpeedQuantity { get; set; }
        public string SpeedUnit { get; set; }
        public string Description { get; set; }

        /* Api Reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }
    }
}
