﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._5
{
    static class Die
    {
        static Random generator = new Random();

        public static int Roll()
        {
            return generator.Next(1, 7);
        }
    }
}
