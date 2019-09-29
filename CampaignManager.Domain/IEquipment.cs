using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public interface IEquipment
    {
        //-- Public Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }

    }
}
