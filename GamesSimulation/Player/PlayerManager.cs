using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Player
{
    public class PlayerManager : IPlayerService

    {
        IPlayerValidationService _playerValidationService;
        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            _playerValidationService = playerValidationService;
        }
        public void Add(Players player)
        {
            if (_playerValidationService.Validate(player)==true)
            {
                Console.WriteLine("Kayıt Basarılı");
            }
            else
            {
                Console.WriteLine("Kayıt Basarısız");
            }
        }

        

        public void Delete(Players player)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Players player)
        {
            Console.WriteLine("Kayıt güncellendi ");
        }
    }
}
