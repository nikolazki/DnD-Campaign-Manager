using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampaignManager.Domain
{
    public class StartingEquipment
    {
        [Key]
        public int ClassId { get; set; }
        public Class Class { get; set; }
        [Key]
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
