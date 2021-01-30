using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSimulation.Game
{
    public class GameManager : IGameService
    {
        public GameManager()
        {

        }
        public void Add(Games game)
        {
            Console.WriteLine("Oyun eklendi.");
        }

        public void Delete(Games game)
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Update(Games game)
        {
            Console.WriteLine("Oyun güncellendi");
        }

       
    }
}
