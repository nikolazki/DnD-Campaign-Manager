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
        IFetchClassesModel FetchClassesModel { get; }
        IClass[] Classes { get; }

        Task RetrieveClassesAsync();
        Task RetrieveUsersAsync();
    }

    public class DashboardViewModel : IDashboardViewModel
    {
        private IFetchUsersModel _fetchUsersModel { get; set; }
        private IFetchClassesModel _fetchClassesModel { get; set; }
        private IUser[] _users { get; set; }
        private IClass[] _classes { get; set; }

        public IFetchUsersModel FetchUsersModel
        {
            get => _fetchUsersModel;
            private set => _fetchUsersModel = value;
        }

        public IFetchClassesModel FetchClassesModel
        {
            get => _fetchClassesModel;
            private set => _fetchClassesModel = value;
        }

        public IUser[] Users
        {
            get => _users;
            private set => _users = value;
        }

        public IClass[] Classes
        {
            get => _classes;
            private set => _classes = value;
        }

        public DashboardViewModel(IFetchUsersModel fetchUsersModel, IFetchClassesModel fetchClassesModel)
        {
            _fetchUsersModel = fetchUsersModel;
            _fetchClassesModel = fetchClassesModel;
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

        public async Task RetrieveClassesAsync()
        {
            List<IClass> newClasses = new List<IClass>();
            await _fetchClassesModel.RetrieveClassesAsync();

            foreach (var cl in _fetchClassesModel.Classes)
            {
                newClasses.Add(new Models.Class
                {
                    name = cl.name,
                    url = cl.url
                });
            }

            _classes = newClasses.ToArray();
        }
    }
}
