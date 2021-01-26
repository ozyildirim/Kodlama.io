using Gun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Concrete
{
    class CampaignManager
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Game '" + campaign.Name + "' is added.");
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
