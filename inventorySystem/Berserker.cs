﻿using System;
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
            _health = 100;
            _maxHealth = _health;
            _Mana = 10;
            _Strength = 10;
            _Agility = 5;
            _Wisdom = 1;
        }
    }
}
