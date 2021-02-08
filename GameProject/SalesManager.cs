using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " " + "adlı oyun" + " " + gamer.FirstName + " " + gamer.LastName + " " + "tarafından satın alındı.");
        }

    }
}
