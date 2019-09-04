﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Charater : Creature
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int _damage = 5;
        private int[] _requiredEXP = { 100, 200, 600, 1000 };


        //character specfic inevntory
       private Inventory inventory = new Inventory();

       //stats base values
       //protected int _Health = 100;
       protected int _Strength = 5;
       protected int _Mana = 100;
       protected int _Agility = 5;
       protected int _Wisdom = 5;

        public Charater(string name)
        {
            _name = name;
            _maxHealth = _health;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _damage + inventory.GetItemDamage() + _Strength;
        }

        //Stats
        public override void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("EXP: " + _xp);
            Console.WriteLine("Health: " + _health);
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

        public override void Fight(Creature target)
        {
            if (Health <= 0)
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

        public override void Fight(Creature[] targets)
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
