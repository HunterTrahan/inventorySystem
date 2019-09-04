using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class DefenseItem : Item
    {
        private int _defense;
        public int Defense
        {
            get
            {
                return _defense;
            }

        }
      

        public DefenseItem(string newName, int newDefense, int newWeight)
        {
            name = newName;
            _defense = newDefense;
            weight = newWeight;
        }
        public void Print()
        {
            Console.WriteLine(name + ": " + _defense+ "\n" + weight);
        }
    }
}
