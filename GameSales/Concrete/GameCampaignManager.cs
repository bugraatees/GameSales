using GameSales.Abstract;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Concrete
{
    public class GameCampaignManager : IGameCamping
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} added" , campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} deleted", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} updated", campaign.CampaignName);
        }
    }
}
