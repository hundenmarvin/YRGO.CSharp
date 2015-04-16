using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YRGO.CS._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            Three();
        }

        static void One()
        {

            var box1 = new Box()
            {
                X = 5,
                Y = 5,
                Width = 10,
                Height = 5
            };

            var box2 = new Box()
            {
                X = 20,
                Y = 6,
                Width = 5,
                Height = 3
            };

            box1.Draw();
            box2.Draw();
        }

        static void Two()
        {
            var box1 = new Box()
            {
                X = 5,
                Y = 5,
                Width = 10,
                Height = 5,
                Color = ConsoleColor.DarkRed
            };

            var box2 = new Box()
            {
                X = 20,
                Y = 6,
                Width = 5,
                Height = 3,
                Color = ConsoleColor.Green
            };

            box1.Draw();
            box2.Draw();
        }

        static void Three()
        {
            var windowHeight = Console.WindowHeight;
            var windowWidth = Console.WindowWidth;

            var generator = new Random();

            while (true)
            {
                var box = new Box();

                box.X = generator.Next(0, windowWidth);
                box.Y = generator.Next(0, windowHeight - 1);
                box.Width = generator.Next(0, windowWidth - box.X);
                box.Height = generator.Next(0, windowHeight - box.Y);
                box.Color = (ConsoleColor)generator.Next(1, 16);

                box.Draw();

                Thread.Sleep(200);
            }
        }
    }
}
