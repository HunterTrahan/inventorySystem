﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Knight : Charater
    {
        public Knight(string name) : base(name)
        {
            _health = 300;
            _maxHealth = _health;
            _Mana = 50;
            _Strength = 7;
            _Agility = 4;
            _Wisdom = 5;
        }
    }
}
