using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Rogue : Charater
    {
        public Rogue(string name) : base(name)
        {
            _health = 80;
            _Mana = 30;
            _Strength = 4;
            _Agility = 10;
            _Wisdom = 4;
        }
    }
}
