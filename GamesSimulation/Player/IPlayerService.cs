using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Player
{
    public interface IPlayerService
    { 
        void Add(Players player);
        void Delete(Players player);
        void Update(Players player);
        
    }
}
