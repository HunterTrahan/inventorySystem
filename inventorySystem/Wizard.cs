using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Wizard : Charater
    {
        public Wizard(string name) : base(name)
        {
            _health = 50;
            _Mana = 100;
            _Strength = 1;
            _Agility = 5;
            _Wisdom = 10;
        }
    }
}
