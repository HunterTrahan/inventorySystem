using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Inventory
    {
        int damage = 5;
        float gold = 0.00f;


        public void Menu()
        {
            string choice = "";

             while (choice != "0")
             {
                //Display menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Uneqip Weapon");
                Console.WriteLine("3: Add Gold");
                Console.WriteLine("4: Subtract Gold");

                //Get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //Check input
                if (choice == "1")
                {
                    equipWeapon();
                }

                else if (choice == "2")
                {
                    unequipWeapon();
                }
                
                else if (choice == "3")
                {
                    Console.Write("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    addGold(addedGold);
                }

                else if (choice == "4")
                {
                    Console.Write("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    subtractGold(addedGold);
                }
             }


        }


        public void equipWeapon()
        {
            Console.WriteLine("Equipped a weapon.");
            damage = 15;
            Console.WriteLine("Damage: " + damage);
        }

        public void unequipWeapon()
        {
            Console.WriteLine("Unequiped a weapon.");
            damage = 5;
            Console.WriteLine("Damage: " + damage);
        }

        public void addGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine(" Gold: " + gold);
        }

        public void subtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            gold -= amount;
            Console.WriteLine(" Gold: " + gold);
        }

    }
}

