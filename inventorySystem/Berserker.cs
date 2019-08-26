using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Berserker : Charater
    {
        public Berserker(string name) : base(name)
        {
            _Health = 100;
            _Mana = 10;
            _Strength = 10;
            _Agility = 5;
            _Wisdom = 1;
        }
    }
}
