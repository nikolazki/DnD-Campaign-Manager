using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Api.Models
{
    public class cost
    {
        public int quantity { get; set; }
        public string unit { get; set; }
    }

    public class damageType
    {
        public string url { get; set; }
        public string name { get; set; }
    }

    public class damage
    {
        public int dice_count { get; set; }
        public int dice_value { get; set; }
        public damageType damage_type { get; set; }
    }

    public class range
    {
        public int normal { get; set; }
        public int? @long { get; set; }
    }

    public class throwRange
    {
        public int normal { get; set; }
        public int @long { get; set; }
    }

    public class damageType2
    {
        public string url { get; set; }
        public string name { get; set; }
    }

    public class __invalid_type__2hDamage
    {
        public int dice_count { get; set; }
        public int dice_value { get; set; }
        public damageType2 damage_type { get; set; }
    }

    public class armorClass
    {
        public int @base { get; set; }
        public bool dex_bonus { get; set; }
        public int? max_bonus { get; set; }
    }

    public class content
    {
        public string item_url { get; set; }
        public int quantity { get; set; }
    }

    public class speed
    {
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class properties
    {
        public string url { get; set; }
        public string name { get; set; }
    }

    public class equipment
    {
        public int index { get; set; }
        public string name { get; set; }
        public string equipment_category { get; set; }
        public string weapon_category { get; set; }
        public string weapon_range { get; set; }
        public string category_range { get; set; }
        public cost cost { get; set; }
        public damage damage { get; set; }
        public range range { get; set; }
        public double? weight { get; set; }
        public List<properties> properties { get; set; }
        public string url { get; set; }
        public throwRange throw_range { get; set; }
        public __invalid_type__2hDamage __invalid_name__2h_damage { get; set; }
        public List<string> special { get; set; }
        public string armor_category { get; set; }
        public armorClass armor_class { get; set; }
        public int? str_minimum { get; set; }
        public bool? stealth_disadvantage { get; set; }
        public string gear_category { get; set; }
        public List<string> desc { get; set; }
        public List<content> contents { get; set; }
        public string tool_category { get; set; }
        public string vehicle_category { get; set; }
        public speed speed { get; set; }
        public string capacity { get; set; }
    }
}
