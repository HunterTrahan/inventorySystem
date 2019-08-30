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
        private int _damage = 5;
        private int[] _requiredEXP = { 100, 200, 600, 1000 };


        //character specfic inevntory
       private Inventory inventory = new Inventory();

       //stats base values
       protected int _Health = 100;
       protected int _Strength = 5;
       protected int _Mana = 100;
       protected int _Agility = 5;
       protected int _Wisdom = 5;

        public Charater(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }

        public int Damage()
        {
            return _damage;
        }

        //Stats
        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("EXP: " + _xp);
            Console.WriteLine("Health: " + _Health);
            Console.WriteLine("Mana: " + _Mana);
            Console.WriteLine("Agility: " + _Agility);
            Console.WriteLine("Strength: " + _Strength);
            Console.WriteLine("Wisdom: " + _Wisdom);
            Console.WriteLine("");
            Console.WriteLine("Item Damage: " + inventory.GetItemDamage());
            Console.WriteLine("Item Defense: " + inventory.GetItemDefense());
            Console.WriteLine("");
            Console.WriteLine("Combat damage: " + (_Strength + inventory.GetItemDamage()));
           
        }

        public void OpenInventory()
        {
            inventory.Menu();
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
