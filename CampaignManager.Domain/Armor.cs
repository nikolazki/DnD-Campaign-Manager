using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Armor : Equipment
    {
        //-- Public Properties
        public string ArmorCategory { get; set; }
        public int BaseArmorClass { get; set; }
        public bool DexterityBonus { get; set; }
        public int? MaxBonus { get; set; }
        public int? MinStrength { get; set; }
        public bool? StealthDisadvantage { get; set; }

        //-- Constructor
        public Armor()
        {
            EquipmentCategory = "Armor";
        }
    }
}
