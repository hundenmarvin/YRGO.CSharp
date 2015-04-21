using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._5
{
    class Game
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public bool IsFinished { get { return _playerOne.HP <= 0 || _playerTwo.HP <= 0; } }

        public Game(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }

        public void NextRound()
        {
            Player playerTurn;
            Player otherPlayer;

            if (Die.Roll() <= 3)
            {
                playerTurn = _playerOne;
                otherPlayer = _playerTwo;
            }
            else
            {
                playerTurn = _playerTwo;
                otherPlayer = _playerOne;
            }

            var damage = Die.Roll();

            otherPlayer.HP -= damage;

            Console.WriteLine("{0} hits {1} for a totalt damage of {2}", playerTurn.Name, otherPlayer.Name, damage);

        }


    }
}
