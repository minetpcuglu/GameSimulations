using GamesSimulation.Game;
using GamesSimulation.Player;
using GamesSimulation.Campaign;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Campaign
{
    public interface ICampaignService
    {
       
        void CampaignBuy(Campaigns campaigns,Games games,Players players);
    }
}
