using GamesSimulation.Player;
using GamesSimulation.Campaign;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Game
{
    public class GameOwnerManager : IGameOwnerService
    {
       

        public void ownGame(Games games, Players players)
        {
            Console.WriteLine(players.PlayerFirstName + " " + games.GamenName + " " + "oyununu satın aldı");
        }


    }
}
