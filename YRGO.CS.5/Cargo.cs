using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._5
{
    class Cargo
    {
        public string Name { get; private set; }
        public int Size { get; private set; }
        public Cargo(string name, int size)
        {
            Name = name;
            Size = size;
        }

    }
}
