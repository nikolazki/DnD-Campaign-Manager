using CampaignManager.Domain;
using CampaignManager.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignManager.UI.ViewModels
{
    public interface IDashboardViewModel
    {
        IFetchUsersModel FetchUsersModel { get; }
        IUser[] Users { get; }

        Task RetrieveUsersAsync();
    }

    public class DashboardViewModel : IDashboardViewModel
    {
        private IFetchUsersModel _fetchUsersModel { get; set; }
        private IUser[] _users { get; set; }

        public IFetchUsersModel FetchUsersModel
        {
            get => _fetchUsersModel;
            private set => _fetchUsersModel = value;
        }

        public IUser[] Users
        {
            get => _users;
            private set => _users = value;
        }

        public DashboardViewModel(IFetchUsersModel fetchUsersModel)
        {
            _fetchUsersModel = fetchUsersModel;
        }

        public async Task RetrieveUsersAsync()
        {
            List<IUser> newUsers = new List<IUser>();
            await _fetchUsersModel.RetrieveUsersAsync();

            foreach (var user in _fetchUsersModel.Users)
            {
                newUsers.Add(new User
                {
                    Username = user.UserName
                });
            }

            _users = newUsers.ToArray();
        }
    }
}
