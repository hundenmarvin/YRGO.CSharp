using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            Four();
        }

        static void One()
        {
            var hugo = new Cat("Hugo");
            hugo.Talk();
        }

        static void Two()
        {
            var hugo = new Cat("Hugo", true);
            hugo.Talk();
        }

        static void Three()
        {
            var hugo = new Cat("Hugo", true);
            var fisker = new Cat("Fisker");

            hugo.Talk();
            fisker.Talk("Need kebab!");

            hugo.Talk("Ooo, kebab!");
            fisker.Talk();
        }

        static void Four()
        {
            var hugo = new Cat("Hugo");
            var fisker = new Cat("Fisker");

            hugo.Eat(fisker);

            // ------------------

            var baltazar = new Cat("Baltazar", true);

            baltazar.Talk();
            fisker.Talk();

            baltazar.Eat(fisker);
            fisker.Talk();
        }
    }
}
