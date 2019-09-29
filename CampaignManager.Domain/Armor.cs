using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Armor : IEquipment
    {
        //-- Public Properties
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArmorCategory { get; set; }
        public int BaseArmorClass { get; set; }
        public bool DexterityBonus { get; set; }
        public int? MaxBonus { get; set; }
        public int? MinStrength { get; set; }
        public int Cost { get; set; } // in cp
        public double Weight { get; set; }
        public bool? StealthDisadvantage { get; set; }

        /* Api Reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }
    }
}
