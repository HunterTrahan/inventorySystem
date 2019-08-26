using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Charater
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredEXP = { 100, 200, 600, 1000 };

        public Charater(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("EXP: " + _xp);
        }

        //exp system
        public int EXP
        {
            get
            {
                return _xp;
            }

            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained EXP and now has " + _xp);
                if (_level <= _requiredEXP.Length)
                {
                    if (_xp >= _requiredEXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + " 's leveled up to " + _level + "!");
                    }
                }
                
            }
        }
    }
}
