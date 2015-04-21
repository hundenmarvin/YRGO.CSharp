using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._5
{
    class BetterSpaceship
    {
        public string Name { get; set; }

        private string _content;
        private int _size;
        private int _free;
        public BetterSpaceship(string name, int size)
        {
            Name = name;
            _size = size;
        }

        public int GetCargoSize()
        {
            return _size - _free;
        }

        public string GetContents()
        {
            return _content ?? String.Empty;
        }

        public void Empty()
        {
            _free = _size;
            _content = String.Empty;
        }

        public bool AddCargo(Cargo cargo)
        {
            if (cargo.Size > _free)
                return false;

            _free -= cargo.Size;
            _content += !String.IsNullOrEmpty(_content) ? "\n" + cargo.Name : cargo.Name;

            return true;
        }

        public void GetInfo()
        {
            Console.WriteLine("== {0} ==", Name);
            Console.WriteLine(!String.IsNullOrEmpty(_content) ? _content : "<no cargo>");
            Console.WriteLine("----");
            Console.WriteLine("Size : {0}", _size);
            Console.WriteLine("Free : {0}", _free);
        }

        public bool TransferCargoFrom(BetterSpaceship otherShip)
        {
            if (otherShip.GetCargoSize() <= 0 || otherShip.GetCargoSize() > _free)
                return false;

            Console.WriteLine("Transfering cargo from {0} to {1}", otherShip.Name, this.Name);

            _content += !String.IsNullOrEmpty(_content) ? "\n" + otherShip.GetContents() : otherShip.GetContents();
            _free -= otherShip.GetCargoSize();
            otherShip.Empty();
            return true;
        }
    }
}
