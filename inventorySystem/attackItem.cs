using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class attackItem : Item
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }

        }

        
       public attackItem(string newName, int newDamage, int newWeight)
       {
            name = newName;
            _damage = newDamage;
            weight = newWeight;
       }

    }
}
