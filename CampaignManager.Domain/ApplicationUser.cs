using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampaignManager.Domain
{
    public class ApplicationUser : IdentityUser
    {
        //-- Relationships
        public ICollection<Character> Characters { get; set; }
    }
}
