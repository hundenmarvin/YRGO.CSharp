using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._5
{
    class Player
    {
        public string Name { get; private set; }
        public int HP { get; set; }

        public Player(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

    }
}
