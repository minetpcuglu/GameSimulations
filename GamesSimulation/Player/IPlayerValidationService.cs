using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Player
{
   public interface IPlayerValidationService
    {
        bool Validate(Players player);
    }
}
