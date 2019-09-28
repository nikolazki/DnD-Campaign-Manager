using CampaignManager.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignManager.UI.Models
{
    public interface IFetchUsersModel
    {
        ApplicationUser[] Users { get; }

        Task RetrieveUsersAsync();
    }

    public class FetchUsersModel : IFetchUsersModel
    {
        private AuthContext _context;
        private ApplicationUser[] _users;
        public ApplicationUser[] Users
        {
            get => _users;
        }

        public FetchUsersModel(AuthContext context)
        {
            _context = context;
        }

        public async Task RetrieveUsersAsync() =>
            _users = await _context.Users.ToArrayAsync();
    }
}
