using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Game
{
    public interface IGameService
    {
        void Add(Games games);
        void Update(Games games);
        void Delete(Games games);
    }
}
