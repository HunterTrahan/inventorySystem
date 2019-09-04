using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Creature
    {
        protected int _health;
        protected int _maxHealth;
        protected DefenseItem Armor;
        public virtual void Fight(Creature target)
        {

        }

        public virtual void Fight(Creature[] targets)
        {

        }

        public virtual int GetDamage()
        {
            return 0;
        }

        public virtual DefenseItem GetArmor()
        {
            if(Armor == null)
            {
                return new DefenseItem("Naked",5,0);
            }
            return Armor;
        }

        public virtual string GetName()
        {
            return "";
        }

        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;

                //Checks for monster max health
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }

                //checks for monster minimum health
                else if (_health < 0)
                {
                    _health = 0;
                }
            }
        }

         public virtual void Print()
         {

         }
    }
}
