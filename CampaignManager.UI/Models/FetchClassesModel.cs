using CampaignManager.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CampaignManager.UI.Models
{
    public interface IFetchClassesModel
    {
        IClass[] Classes { get; }

        Task RetrieveClassesAsync();
    }

    public class FetchClassesModel : IFetchClassesModel
    {
        private JsonClassList _classes;
        private IHttpClientFactory _httpClientFactory;

        public IClass[] Classes
        {
            get => _classes.results.ToArray();
        }

        public FetchClassesModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task RetrieveClassesAsync()
        {
            var client = _httpClientFactory.CreateClient();
            _classes = await client.GetJsonAsync<JsonClassList>("http://dnd5eapi.co/api/classes/");
        }
    }
}
