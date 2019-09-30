using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Weapon : Equipment
    {
        //-- Public Properties
        public string WeaponCategory { get; set; }
        public string WeaponRange { get; set; }
        public string CategoryRange { get; set; }
        public int DiceCount { get; set; }
        public int DiceValue { get; set; }
        public int? NormalRange { get; set; }
        public int? LongRange { get; set; }
        public int? NormalThrowRange { get; set; }
        public int? LongThrowRange { get; set; }

        //-- Relationships
        public int DamageTypeId { get; set; }
        public DamageType DamageType { get; set; }
        public ICollection<WeaponProperty> WeaponProperties { get; set; }

        //-- Constructor
        public Weapon()
        {
            EquipmentCategory = "Weapons";
        }

    }
}
