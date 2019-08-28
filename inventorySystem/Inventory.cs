using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Inventory
    {
       private int _damage = 5;
       private bool _hasWeapon = false;
       private int _defense = 5;
       private bool _hasArmor = false;
       private int _armorValue = 0;
       private int _weightTotal = 0;
       private int _weightFromWeapon = 0;
       private int _weightFromArmor = 0;
       private int _weightLimit = 50;
       private float _gold = 0.00f;
       private attackItem[] _weapons;
       private DefenseItem[] _armor;

        //Populates the weapon list (Array)
        private attackItem Dagger = new attackItem("Iron Dagger", 10, 5);
        private attackItem Sword = new attackItem("Steel Sword", 15, 15);
        private attackItem Sword2 = new attackItem("Claymore", 25, 20);
        private attackItem Hammer = new attackItem("Warhammer", 30, 30);


        //Populates the armor list (Array)
        private DefenseItem Leather = new DefenseItem("Leather Tunic", 10, 15);
        private DefenseItem Iron = new DefenseItem("Iron Armor", 15, 20);
        private DefenseItem Steel = new DefenseItem("Steel Armor", 20, 35);
        private DefenseItem Platnium = new DefenseItem("Platnium Armor", 25, 40);
        

        public Inventory()
        {
            attackItem[] weaponBag = { Dagger, Sword, Sword2, Hammer};
            _weapons = weaponBag;

            DefenseItem[] armorBag = { Leather, Iron, Steel, Platnium };
            _armor = armorBag;
        }

        //Returns the damage of weapons
        public int GetItemDamage()
        {
            return _damage;
        }

        //retrns the defense of armor
        public int GetItemDefense()
        {
            return _defense;
        }


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
                    _weightTotal = _weightFromArmor + _weightFromWeapon;
                    Console.WriteLine("Damage: " + _damage + " Weight: " + _weightTotal);
                }

                else if (choice == "2")
                {
                    unequipWeapon();
                    // Update total weight
                    _weightTotal = _weightFromArmor + _weightFromWeapon;
                    Console.WriteLine("Damage: " + _damage + " Weight: " + _weightTotal);
                }

                else if (choice == "3")
                {
                    equipArmor();
                    // Update total weight
                    _weightTotal = _weightFromArmor + _weightFromWeapon;
                    Console.WriteLine("defense: " + (_armorValue + _defense) + " weight: " + _weightTotal);
                }

                else if (choice == "4")
                {
                    unequipArmor();
                    // Update total weight
                    _weightTotal = _weightFromArmor + _weightFromWeapon;
                    Console.WriteLine("defense: " + (_armorValue + _defense) + " weight: " + _weightTotal);
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

            if (!_hasWeapon)
            {

                while (menu2 != "0")
                {
                    Console.WriteLine("\nWeapon list");
                    Console.WriteLine("0: Back");
                    Console.WriteLine("1: Iron Dagger");
                    Console.WriteLine("2: Steel Sword");
                    Console.WriteLine("3: Claymore");
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
                        if(checkWeight(_weightFromArmor, 5))
                        {
                            Console.WriteLine("Equipped a Iron Dagger.");
                            _damage = _weapons[0].Damage;
                            _weightFromWeapon = _weapons[0].Weight;
                            Console.WriteLine("Damage: " + _damage + "." + " Weight added 5.");
                            _hasWeapon = true;
                            menu2 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

                    }

                    else if (choice2 == "2")
                    {
                        if(checkWeight(_weightFromArmor, 10))
                        {
                            Console.WriteLine("Equipped a Steel Sword.");
                            _damage = _weapons[1].Damage;
                            _weightFromWeapon = _weapons[1].Weight;
                            Console.WriteLine("Damage: " + _damage + "." + " Weight added 15.");
                            _hasWeapon = true;
                            menu2 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

                    }

                    else if (choice2 == "3")
                    {
                        if(checkWeight(_weightFromArmor, 20))
                        {
                            Console.WriteLine("Equipped a Claymore.");
                            _damage = _weapons[2].Damage;
                            _weightFromWeapon = _weapons[2].Weight;
                            Console.WriteLine("Damage: " + _damage + "." + " Weight added 20.");
                            _hasWeapon = true;
                            menu2 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

                    }

                    else if (choice2 == "4")
                    {
                        if(checkWeight(_weightFromArmor, 30))
                        {
                            Console.WriteLine("Equipped a Warhammer.");
                            _damage = _weapons[3].Damage;
                            _weightFromWeapon = _weapons[3].Weight;
                            Console.WriteLine("Damage: " + _damage + "." + " Weight added 30.");
                            _hasWeapon = true;
                            menu2 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

                    }

                }

            }


            else
            {
                Console.WriteLine("There is a weapon equipped." + " Current weight amount " + _weightFromWeapon + ".");
            }
        }

        public void unequipWeapon()
        {
            if (_hasWeapon)
            {
                Console.WriteLine("Unequiped a weapon.");
                _damage = 5;
                _weightFromWeapon = 0;
                
                _hasWeapon = false;
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

            if (!_hasArmor)
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
                        if(checkWeight(_weightFromWeapon, 15))
                        {
                            Console.WriteLine("Equipped Leather tunic.");
                            _armorValue = _armor[0].Defense;
                            _weightFromArmor = _armor[0].Weight;
                            Console.WriteLine("Defense: " + _armorValue);
                            _hasArmor = true;
                            menu3 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }
                       
                    }

                    else if (choice2 == "2")
                    {
                        if(checkWeight(_weightFromWeapon, 20))
                        {
                            Console.WriteLine("Equipped Iron armor.");
                            _armorValue = _armor[1].Defense;
                            _weightFromArmor = _armor[1].Weight;
                            Console.WriteLine("Defense: " + _armorValue);
                            _hasArmor = true;
                            menu3 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

                    }

                    else if (choice2 == "3")
                    {
                        if(checkWeight(_weightFromWeapon, 25))
                        {
                            Console.WriteLine("Equipped Steel armor.");
                            _armorValue = _armor[2].Defense;
                            _weightFromArmor = _armor[2].Weight;
                            Console.WriteLine("Defense: " + _armorValue);
                            _hasArmor = true;
                            menu3 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

                    }

                    else if (choice2 == "4")
                    {
                        if(checkWeight(_weightFromWeapon, 40))
                        {
                            Console.WriteLine("Equipped Platnium armor.");
                            _armorValue = _armor[3].Defense;
                            _weightFromArmor = _armor[3].Defense;
                            Console.WriteLine("Defense: " + _armorValue);
                            _hasArmor = true;
                            menu3 = "0";
                        }

                        else
                        {
                            Console.WriteLine("Weight limit reached");
                        }

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
            if (_hasArmor)
            {
                Console.WriteLine("Unequiped armor.");
                _armorValue = 0;
                _hasArmor = false;
                _weightFromArmor = 0;
                
                _defense = 5;
            }

            else
            {
                Console.WriteLine("There is no armor equipped");
            }

        }

        //weight System
        public bool checkWeight(int weightFromWeapon, int weightFromArmor)
        {
            if (weightFromWeapon + weightFromArmor <= _weightLimit)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //gold System
        public void addGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine(" Gold: " + _gold);
        }

        public void subtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            _gold -= amount;

            if (_gold < 0) ;
            {
                _gold = 0;
            }

            Console.WriteLine(" Gold: " + _gold);
        }

    }
}

