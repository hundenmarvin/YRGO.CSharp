using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Three();
            Four();
        }

        static void One()
        {
            var galactica = new Spaceship()
            {
                Name = "Battlestar Galactica",
                Size = 10,
                Free = 10
            };

            galactica.GetInfo();
            Cargo cargo;

            do
            {
                cargo = new Cargo()
                {
                    Name = "Nuclear Warhead",
                    Size = 3
                };
            } while (galactica.AddCargo(cargo));

            galactica.GetInfo();
        }

        static void Three()
        {
            var condor = new BetterSpaceship()
            {
                Name = "Condor class transport ship 1",
            };
            condor.SetSize(25);
            condor.AddCargo(new Cargo { Name = "Five thousand Marines", Size = 15 });
            condor.AddCargo(new Cargo { Name = "Ammunition", Size = 3 });
            condor.GetInfo();

            Console.WriteLine("Cargo size = {0}", condor.GetCargoSize());
            Console.WriteLine();
            Console.WriteLine("Dumping cargo!");
            Console.WriteLine();

            condor.Empty();
            condor.GetInfo();
        }

        static void Four()
        {
            var condor = new BetterSpaceship()
            {
                Name = "Condor class transport ship 1",
            };
            condor.SetSize(25);
            condor.AddCargo(new Cargo { Name = "Five thousand Marines", Size = 15 });
            condor.AddCargo(new Cargo { Name = "Ammunition", Size = 3 });
            condor.GetInfo();

            var condor2 = new BetterSpaceship()
            {
                Name = "Condor class transport ship 2",
            };
            condor2.SetSize(25);
            condor2.AddCargo(new Cargo { Name = "Ammunition", Size = 3 });
            condor2.AddCargo(new Cargo { Name = "Ammunition", Size = 3 });
            condor2.GetInfo();

            Console.WriteLine();

            condor2.TransferCargoFrom(condor);
            condor.GetInfo();

            Console.WriteLine();
            Console.WriteLine();

            condor2.GetInfo();
        }
    }
}
