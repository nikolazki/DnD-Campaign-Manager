using System.Collections.Generic;

public class from
{
    public string url { get; set; }
    public string name { get; set; }
}

public class proficiencyChoice
{
    public int choose { get; set; }
    public string type { get; set; }
    public List<from> from { get; set; }
}

public class proficiency
{
    public string name { get; set; }
    public string url { get; set; }
}

public class savingThrow
{
    public string name { get; set; }
    public string url { get; set; }
}

public class startingEquipment
{
    public string url { get; set; }
    public string @class { get; set; }
}

public class classLevels
{
    public string url { get; set; }
    public string @class { get; set; }
}

public class subclass
{
    public string url { get; set; }
    public string name { get; set; }
}

public class spellcasting
{
    public string url { get; set; }
    public string @class { get; set; }
}

public class classes
{
    public int index { get; set; }
    public string name { get; set; }
    public int hit_die { get; set; }
    public List<proficiencyChoice> proficiency_choices { get; set; }
    public List<proficiency> proficiencies { get; set; }
    public List<savingThrow> saving_throws { get; set; }
    public startingEquipment starting_equipment { get; set; }
    public classLevels class_levels { get; set; }
    public List<subclass> subclasses { get; set; }
    public spellcasting spellcasting { get; set; }
    public string url { get; set; }
}