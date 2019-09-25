using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CampaignManager.Domain
{
    public class Race
    {
        //-- Public Properties
        public int Id { get; set; }
        public string Name { get; set; }

        //-- Relationships
        public int? ParentRaceId { get; set; }
        public virtual Race ParentRace { get; set; }
        public ICollection<Race> ChildRaces { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
