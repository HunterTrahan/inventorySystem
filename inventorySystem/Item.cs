using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Item
    {
        protected int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
        }

        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
