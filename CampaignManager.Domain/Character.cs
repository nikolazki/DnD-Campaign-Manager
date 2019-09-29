using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampaignManager.Domain
{
    public class Character
    {
        //-- Constructor
        public Character() { }

        //-- Public Properties
        public int Id { get; set; }

        /* Personal Info */
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /* Base Abilitiy Scores */
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //-- Relationships
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public int RaceId { get; set; }
        public Race Race { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
