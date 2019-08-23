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
        int weapon = 0;
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

            string menu2 = "";

            if (weapon == 0)
            {

                while (menu2 != "0")
                {
                    Console.WriteLine("\nWeapon list");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Dagger");
                    Console.WriteLine("2: Sword");
                    Console.WriteLine("3: Greatsword");
                    Console.WriteLine("4: Warhammer");

                    string choice2 = "";

                    choice2 = Console.ReadLine();
                    Console.WriteLine("");


                    if (choice2 == "0")
                    {
                        menu2 = "0";
                    }

                    else if (choice2 == "1")
                    {
                        Console.WriteLine("Equipped a dagger.");
                        damage = 10;
                        Console.WriteLine("Damage: " + damage);
                        weapon = 1;
                        menu2 = "0";
                    }

                    else if (choice2 == "2")
                    {
                        Console.WriteLine("Equipped a sword.");
                        damage = 15;
                        Console.WriteLine("Damage: " + damage);
                        weapon = 1;
                        menu2 = "0";
                    }

                    else if (choice2 == "3")
                    {
                        Console.WriteLine("Equipped a Greatsword.");
                        damage = 20;
                        Console.WriteLine("Damage: " + damage);
                        weapon = 1;
                        menu2 = "0";
                    }

                    else if (choice2 == "4")
                    {
                        Console.WriteLine("Equipped a Warhammer.");
                        damage = 25;
                        Console.WriteLine("Damage: " + damage);
                        weapon = 1;
                        menu2 = "0";
                    }

                }

            }


            else
            {
                Console.WriteLine("There is a weapon equipped");
            }
        }

        public void unequipWeapon()
        {
            if (weapon == 1)
            {
                Console.WriteLine("Unequiped a weapon.");
                damage = 5;
                Console.WriteLine("Damage: " + damage);
                weapon = 0;
            }

            else
            {
                Console.WriteLine("There is no weapon equipped");
            }
            
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

            if (gold < 0);
            {
                gold = 0;
            }

            Console.WriteLine(" Gold: " + gold);
        }

    }
}

