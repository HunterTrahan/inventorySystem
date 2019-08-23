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
        bool hasWeapon = false;
        int defense = 5;
        bool hasArmor = false;
        int armorValue = 0;
        int weightTotal = 0;
        int weightFromWeapon = 0;
        int weightFromArmor = 0;
        int weightLimit = 100;
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
                Console.WriteLine("3: Equip Armor");
                Console.WriteLine("4: Unequip Armor");
                Console.WriteLine("5: Add Gold");
                Console.WriteLine("6: Subtract Gold");

               

                //Get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //Check input
                if (choice == "1")
                {
                   equipWeapon();
                    // Update total weight
                    weightTotal = weightFromArmor + weightFromWeapon;
                    Console.WriteLine("Damage: " + damage + " Weight: " + weightTotal);
                }

                else if (choice == "2")
                {
                    unequipWeapon();
                    // Update total weight
                    weightTotal = weightFromArmor + weightFromWeapon;
                    Console.WriteLine("Damage: " + damage + " Weight: " + weightTotal);
                }

                else if (choice == "3")
                {
                    equipArmor();
                    // Update total weight
                    weightTotal = weightFromArmor + weightFromWeapon;
                    Console.WriteLine("defense: " + (armorValue + defense) + " weight: " + weightTotal);
                }

                else if (choice == "4")
                {
                    unequipArmor();
                    // Update total weight
                    weightTotal = weightFromArmor + weightFromWeapon;
                    Console.WriteLine("defense: " + (armorValue + defense) + " weight: " + weightTotal);
                }

                else if (choice == "5")
                {
                    Console.Write("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    addGold(addedGold);
                }

                else if (choice == "6")
                {
                    Console.Write("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    subtractGold(addedGold);
                }
             }


        }



        //weapon System
        public void equipWeapon()
        {

            string menu2 = "";

            if (!hasWeapon)
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
                        weightFromWeapon = 5;
                        Console.WriteLine("Damage: " + damage + "." + " Weight added 5.");
                        hasWeapon = true;
                        menu2 = "0";
                    }

                    else if (choice2 == "2")
                    {
                        Console.WriteLine("Equipped a sword.");
                        damage = 15;
                        weightFromWeapon = 10;
                        Console.WriteLine("Damage: " + damage + "." + " Weight added 10.");
                        hasWeapon = true;
                        menu2 = "0";
                    }

                    else if (choice2 == "3")
                    {
                        Console.WriteLine("Equipped a Greatsword.");
                        damage = 20;
                        weightFromWeapon = 15;
                        Console.WriteLine("Damage: " + damage + "." + " Weight added 15.");
                        hasWeapon= true;
                        menu2 = "0";
                    }

                    else if (choice2 == "4")
                    {
                        Console.WriteLine("Equipped a Warhammer.");
                        damage = 25;
                        weightFromWeapon = 20;
                        Console.WriteLine("Damage: " + damage + "." + " Weight added 20.");
                        hasWeapon = true;
                        menu2 = "0";
                    }

                }

            }


            else
            {
                Console.WriteLine("There is a weapon equipped." + " Current weight amount " + weightFromWeapon + ".");
            }
        }

        public void unequipWeapon()
        {
            if (hasWeapon)
            {
                Console.WriteLine("Unequiped a weapon.");
                damage = 5;
                weightFromWeapon = 0;
                
                hasWeapon = false;
            }

            else
            {
                Console.WriteLine("There is no weapon equipped.");
            }
            
        }

        //armor System
        public void equipArmor()
        {
            string menu3 = "";

            if (!hasArmor)
            {

                while (menu3 != "0")
                {
                    Console.WriteLine("\nArmor list");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Leather");
                    Console.WriteLine("2: Iron");
                    Console.WriteLine("3: Steel");
                    Console.WriteLine("4: Platnium");

                    string choice2 = "";

                    choice2 = Console.ReadLine();
                    Console.WriteLine("");


                    if (choice2 == "0")
                    {
                        menu3 = "0";
                    }

                    else if (choice2 == "1")
                    {
                        Console.WriteLine("Equipped Leather armor.");
                        armorValue = 10;
                        weightFromArmor = 15;
                        Console.WriteLine("Defense: " + armorValue);
                        hasArmor = true;
                        menu3 = "0";
                    }

                    else if (choice2 == "2")
                    {
                        Console.WriteLine("Equipped Iron armor.");
                        armorValue= 15;
                        weightFromArmor = 20;
                        Console.WriteLine("Defense: " + armorValue);
                        hasArmor = true;
                        menu3 = "0";
                    }

                    else if (choice2 == "3")
                    {
                        Console.WriteLine("Equipped Steel armor.");
                        armorValue = 20;
                        weightFromArmor = 25;
                        Console.WriteLine("Defense: " + armorValue);
                        hasArmor = true;
                        menu3 = "0";
                    }

                    else if (choice2 == "4")
                    {
                        Console.WriteLine("Equipped Platnium armor.");
                        armorValue = 25;
                        weightFromArmor = 30;
                        Console.WriteLine("Defense: " + armorValue);
                        hasArmor = true;
                        menu3 = "0";
                    }

                }

            }

            else
            {
                Console.WriteLine("There is armor equipped");
            }
        }

        public void unequipArmor()
        {
            if (hasArmor)
            {
                Console.WriteLine("Unequiped armor.");
                armorValue = 0;
                hasArmor = false;
                weightFromArmor = 0;
                
                defense = 5;
            }

            else
            {
                Console.WriteLine("There is no armor equipped");
            }

        }

        //weight System
        public void checkWeight()
        {
            if (weightFromWeapon + weightFromArmor <= weightLimit)
            {

            }
        }

        //gold System
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

