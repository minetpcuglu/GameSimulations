using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Player
{
    public class PlayerValidationManager : IPlayerValidationService
    {
        public PlayerValidationManager()
        {

        }
        public bool Validate(Players player)
        {
            if (player.PlayerFirstName == "Mine" && player.PlayerLastName == "Topcuoglu" && player.PlayerId == 5 && player.PlayerBirthDay == "25.10.1999") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
