using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._3
{
    class Box
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor Color { get; set; }

        public void Draw()
        {
            var originalBackgroundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;

            if (Color != null)
            {
                Console.BackgroundColor = Color;
                Console.ForegroundColor = Color;
            }

            for (int j = 0; j < Height; j++)
            {
                Console.SetCursorPosition(X, Y + j);
                for (int i = 0; i < Width; i++)
                    Console.Write("X");
            }

            Console.BackgroundColor = originalBackgroundColor;
            Console.ForegroundColor = originalForegroundColor;
        }
    }
}
