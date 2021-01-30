using System;
using System.Collections.Generic;
using System.Text;
using GamesSimulation.Game;
using GamesSimulation.Player;
using GamesSimulation.Campaign;

namespace GamesSimulation.Campaign
{
    public class CampaignManager : ICampaignService
    {
       
        
      

        public void CampaignBuy(Campaigns campaigns, Games games, Players players)
        {
            Console.WriteLine(players.PlayerFirstName  + " Adlı kullanıcı " + games.GamenName + "Oyununu " +campaigns.CampaignName+ "Kampanyasından % "+campaigns.Campaigndiscountamount + "indiriminden faydalanarak "+ games.GamePrice + " TL' ye satın aldı" );
            
        }
       

    }
}
