using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._4
{
    class Spaceship
    {
        private string _content;

        public string Name { get; set; }
        public int Size { get; set; }
        public int Free { get; set; }

        public bool AddCargo(Cargo cargo)
        {
            if (cargo.Size > Free)
                return false;

            Free -= cargo.Size;
            _content += !String.IsNullOrEmpty(_content) ? "\n" + cargo.Name : cargo.Name;

            return true;
        }

        public void GetInfo()
        {
            Console.WriteLine("== {0} ==", Name);
            Console.WriteLine(!String.IsNullOrEmpty(_content) ? _content : "<no cargo>");
            Console.WriteLine("----");
            Console.WriteLine("Size : {0}", Size);
            Console.WriteLine("Free : {0}", Free);
        }
    }
}
