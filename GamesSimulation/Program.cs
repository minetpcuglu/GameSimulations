using System;
using GamesSimulation.Player;
using GamesSimulation.Game;
using GamesSimulation.Campaign;


namespace GamesSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASAMA 1  player ekleme  
            Players players = new Players { PlayerFirstName = "Mine", PlayerLastName = "Topcuoglu", PlayerId = 5, PlayerBirthDay = "25.10.1999" };

            PlayerManager playerManager = new PlayerManager(new PlayerValidationManager());
            playerManager.Add(players);

            //ASAMA 2 oyun ekleme

            Games games = new Games { GamenName = " STAR ", GamePrice = 175, GameId = 1 };

            GameManager gameManager = new GameManager();
            gameManager.Add(games);

            //ASAMA 3 oyun satın alma

            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.ownGame(games, players);

            //ASAMA 4 oyunu kampanya ile satın alma kısmı

            Campaigns campaigns = new Campaigns
            { 
                CampaignName = " Süper Kasım ",
                Campaigndiscountamount =  20 
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignBuy(campaigns,games, players);

           

        }
    }
}
