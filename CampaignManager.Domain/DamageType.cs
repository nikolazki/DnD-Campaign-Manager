﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManager.Domain
{
    public class DamageType
    {
        /* Data we care about */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        /* Api Reference */
        public int ApiId { get; set; }
        public string ApiUrl { get; set; }
    }
}
