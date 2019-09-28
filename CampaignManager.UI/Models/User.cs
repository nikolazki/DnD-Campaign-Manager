using CampaignManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignManager.UI.Models
{
    public interface IUser
    {
        List<Character> Characters { get; set; }
        string Username { get; set; }
    }

    public class User : IUser
    {
        public string Username { get; set; }
        public List<Character> Characters { get; set; }
    }
}
