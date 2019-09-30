using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public interface IEquipment
    {
        //-- Public Properties
        int Id { get; set; }
        string Name { get; set; }
        int Cost { get; set; }
        string EquipmentCategory { get; set; }
        double? Weight { get; set; }
        int ApiId { get; set; }
        string ApiUrl { get; set; }

    }

    public class Equipment : IEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EquipmentCategory { get; set; }
        public int Cost { get; set; } // in cp
        public double? Weight { get; set; }
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }
    }
}
