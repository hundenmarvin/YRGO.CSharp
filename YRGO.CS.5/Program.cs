using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Three();
        }

        static void Three()
        {
            var playerOne = new Player("Kung Fu Chuck", 250);
            var playerTwo = new Player("Torpedoo Munchkin", 250);

            var game = new Game(playerOne, playerTwo);

            while (!game.IsFinished)
            {
                game.NextRound();
            }

            Console.WriteLine("GAME OVER!");

            var winner = playerOne.HP > playerTwo.HP ? playerOne : playerTwo;

            Console.WriteLine("Winner with {0} HP left, {1}", winner.HP, winner.Name);
        }
    }
}
