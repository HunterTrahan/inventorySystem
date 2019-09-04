using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Monster : Creature
    {
        private string _name = "";
        private int _monsterDamage = 10;
        private int _exp;


        public Monster(string name, int health, int damage, int exp)
        {
            _name = name;
            _health = health;
            _maxHealth = health;
            _monsterDamage = damage;
            _exp = exp;

        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _monsterDamage;
        }

        
        public override void Print()
        {
            Console.WriteLine("\n" + _name);
            Console.WriteLine("Health: " + _health + "/" + _maxHealth);
            Console.WriteLine("Damage: " + _monsterDamage);
        }

        public override void Fight(Creature target)
        {
            if(Health <= 0)
            {
                return;
            }

            int health = Health;

            //get the damage of this monster
            int damage = GetDamage() - target.GetArmor().Defense;
            //subtract the damatge from target monsters health
            target.Health -= damage; 
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + " damage!");
        }

        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            
            int choice = Program.random.Next(0, targets.Length);
            Fight(targets[choice]);
        
            
            //bool validInput = false;

            //while (!validInput)
            //{
            //    //Print menu
            //    Console.WriteLine("\nWho will " + GetName() + " fight? ");
            //    //Iterate through targets

            //    for (int i = 0; i < targets.Length; i++)
            //    {
            //        //Print each options with a number and current target
            //        string targetName = targets[i].GetName();
            //        Console.WriteLine(i + ": " + targetName);
            //    }

            //    //readLine to get user input
            //    string input = Console.ReadLine();
            //    //convert the input too an integer
            //    int choice = Convert.ToInt32(input);
            //    //check that the choice is valid (above 0 and below the arry length
            //    if (choice >= 0 && choice < targets.Length)
            //    {
            //        //set validinput to true
            //        validInput = true;
            //        //Fight the chosen target
            //        Fight(targets[choice]);
            //    }
                
            //}

        }


    }


}
