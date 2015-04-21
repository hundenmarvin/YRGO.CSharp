using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._6
{
    class Cat
    {
        public string Name { get; set; }
        private bool IsZombie { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public Cat(string name, bool isZombie)
        {
            Name = name;
            IsZombie = isZombie;
        }

        public void Talk()
        {
            if(IsZombie)
                Console.WriteLine("<{0}> Braaains!", Name);
            else
                Console.WriteLine("<{0}> Mjaooo!", Name);
        }

        public void Talk(string text)
        {
            if (IsZombie || String.IsNullOrEmpty(text))
                Talk();
            else
                Console.WriteLine("<{0}> {1}", Name, text);
        }

        public void Eat(Cat cat)
        {
            if (IsZombie)
            {
                Console.WriteLine("<{0}> Nom nom nom!", Name);
                cat.IsZombie = true;
            }
            else
            {
                Console.WriteLine("<{0}> I'm not a cannibal! I will NOT eat {1}!", Name, cat.Name);
            }
        }
    }
}
