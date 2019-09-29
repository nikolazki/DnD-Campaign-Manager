﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class MountsAndVehicles : Equipment
    {
        //-- Public Properties
        /* Data we care about */
        public string VehicleCategory { get; set; }
        public double? SpeedQuantity { get; set; }
        public string SpeedUnit { get; set; }
        public string Description { get; set; }

        public MountsAndVehicles()
        {
            _equipmentType = "Mounts and Vehicles";
        }
    }
}
