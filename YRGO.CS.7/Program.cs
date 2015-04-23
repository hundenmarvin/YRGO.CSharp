using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            //Four();
            Five();
        }

        static void One()
        {
            Console.WriteLine(Utility.GetLastname("Hari Seldon"));
        }

        static void Two()
        {
            Console.WriteLine("hello, Trantor!".ToUpperFirst());
        }

        static void Three()
        {
            Console.WriteLine("Using psychohistory, hari seldon mathematically determines the future.".ToUpperWord());
        }

        static void Four()
        {
            var input = "+123,m -40 +10 p+23, -3";
            var total = Utility.SumStringNumbers(input);

            Console.WriteLine("Sum of '{0}' is {1}", input, total);
        }

        static Random generator = new Random();
        static void Five()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Round {0}", i);
                var winsSwitch = MontyHall(switchDoor: true);
                var winsNoSwitch = MontyHall(switchDoor: false);

                Console.WriteLine("Wins when not switching door: {0}", winsNoSwitch);
                Console.WriteLine("Wins when switching door:     {0}", winsSwitch);
            }
        }

        private static int MontyHall(bool switchDoor)
        {
            var wins = 0;
            
            for (int i = 0; i < 1000; i++)
            {
                var doors = new Dictionary<int, bool>();
                var winnerDoor = generator.Next(0, 3);

                for (int j = 0; j < 3; j++)
                {
                    if (j == winnerDoor)
                        doors.Add(j, true);
                    else
                        doors.Add(j, false);
                }

                var doorNumber = generator.Next(0, 3);
                var selectedDoor = doors.Single(x => x.Key == doorNumber);

                var doorToRemove = doors.Where(x => x.Key != doorNumber).First(x => !x.Value);

                doors.Remove(doorToRemove.Key);

                if (switchDoor)
                    selectedDoor = doors.Single(x => x.Key != doorNumber);

                if (selectedDoor.Value)
                    wins++;
            }

            return wins;
        }
    }
}
