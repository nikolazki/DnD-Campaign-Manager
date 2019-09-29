using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class Weapon : IEquipment
    {
        //-- Public Properties
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public string WeaponCategory { get; set; }
        public string WeaponRange { get; set; }
        public string CategoryRange { get; set; }
        public int Cost { get; set; } // in CP
        public double Weight { get; set; }
        public int DiceCount { get; set; }
        public int DiceValue { get; set; }
        public int? NormalRange { get; set; }
        public int? LongRange { get; set; }
        public int? NormalThrowRange { get; set; }
        public int? LongThrowRange { get; set; }

        /* Api Reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }

        //-- Relationships
        public int DamageTypeId { get; set; }
        public DamageType DamageType { get; set; }
        public ICollection<WeaponProperty> WeaponProperties { get; set; }

    }
}
