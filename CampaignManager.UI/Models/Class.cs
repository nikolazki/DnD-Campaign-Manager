using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampaignManager.UI.Models
{
    public interface IClass
    {
        string name { get; set; }
        string url { get; set; }
    }

    public class Class : IClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class JsonClassList
    {
        public int count { get; set; }
        public List<Class> results { get; set; }
    }
}
