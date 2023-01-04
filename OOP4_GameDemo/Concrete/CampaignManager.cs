using OOP4_GameDemo.Abstract;
using OOP4_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName + " campaign is added" );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign is deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign is updated");
        }
    }
}
