using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampaignManager.Domain
{
    public class WeaponProperty
    {
        [Key]
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        [Key]
        public int WeaponPropertyTypeId { get; set; }
        public WeaponPropertyType WeaponPropertyType { get; set; }


    }
}
