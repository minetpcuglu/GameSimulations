using GamesSimulation.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Game
{
    public interface IGameOwnerService
    {
        void ownGame(Games games, Players players);
    }
}
