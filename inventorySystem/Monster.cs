using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Monster
    {
        private string _name = "";
        private int _monsterHealth = 150;
        private int _monsterMaxHealth = 200;
        private int _monsterDamage = 10;


        public Monster(string name, int health, int damage)
        {
            _name = name;
            _monsterHealth = health;
            _monsterDamage = damage;

        }

        public string GetName()
        {
            return _name;
        }

        public int GetDamage()
        {
            return _monsterDamage;
        }

        public int Health
        {
            get
            {
                return _monsterHealth;
            }

            set
            {
                _monsterHealth = value;

                //Checks for monster max health
                if (_monsterHealth > _monsterMaxHealth)
                {
                    _monsterDamage = _monsterMaxHealth;
                }

                //checks for monster minimum health
                else if (_monsterHealth < 0)
                {
                    _monsterHealth = 0;
                }
            }
        }

        
        public void Print()
        {
            Console.WriteLine("\n" + _name);
            Console.WriteLine("Health: " + _monsterHealth + "/" + _monsterMaxHealth);
            Console.WriteLine("Damage: " + _monsterDamage);
        }

        public void Fight(Monster target)
        {
            if(Health <= 0)
            {
                return;
            }

            int health = Health;

            //get the damage of this monster
            int damage = GetDamage();
            //subtract the damatge from target monsters health
            target.Health -= damage; 
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + " damage!");
        }

        public void Fight(Monster[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            bool validInput = false;

            while (!validInput)
            {
                //Print menu
                Console.WriteLine("\nWho will " + GetName() + " fight? ");
                //Iterate through targets

                for (int i = 0; i < targets.Length; i++)
                {
                    //Print each options with a number and current target
                    string targetName = targets[i].GetName();
                    Console.WriteLine(i + ": " + targetName);
                }

                //readLine to get user input
                string input = Console.ReadLine();
                //convert the input too an integer
                int choice = Convert.ToInt32(input);
                //check that the choice is valid (above 0 and below the arry length
                if (choice >= 0 && choice < targets.Length)
                {
                    //set validinput to true
                    validInput = true;
                    //Fight the chosen target
                    Fight(targets[choice]);
                }
                
            }

        }


    }


}
