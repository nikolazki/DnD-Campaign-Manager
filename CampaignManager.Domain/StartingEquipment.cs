using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class StartingEquipment
    {
        //-- Public Properties
        public int Id { get; set; }
        public int Quantity { get; set; }

        //-- Relationships
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
