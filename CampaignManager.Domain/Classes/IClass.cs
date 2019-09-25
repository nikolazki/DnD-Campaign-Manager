using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain.Classes
{
    public interface IClass
    {
        int Id { get; set; }



        string GetClassDescription();
    }
}
