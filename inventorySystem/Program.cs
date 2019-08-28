using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {

            //monster list
            Monster slime = new Monster("Slime", 100 , 10);
            Monster skeleton = new Monster("Skeleton", 150, 20);
            Monster zombie = new Monster("Zombie", 200, 5);
            Monster wolf = new Monster("Wolf", 150, 15);

            //monster arrays used to make teams
            Monster[] goodTeam = { slime, skeleton};
            Monster[] evilTeam = { zombie, wolf };

            //encounter from the two arrays of monsters
            Encounter encounter = new Encounter(goodTeam, evilTeam);

            encounter.Print();

            Console.WriteLine("");
            encounter.Start ();

            Console.ReadKey();
            return;

            //Inventory inventory = new Inventory();
            //inventory.Menu();
            string name = "";
            string choice = "";

            //start
            Console.WriteLine("Enter the name of party member 1: ");
            name = Console.ReadLine();

            //Player Creation
            while (choice != "1" && choice != "2")
            {
                //display menu
                Console.WriteLine("\nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Rogue");
                choice = Console.ReadLine();
            }

            Charater player;
            if (choice == "1")
            {
                player = new Knight(name);
            }
            else if (choice == "2")
            {
                player = new Rogue(name);
            }
            else
            {
                player = new Charater(name);
            }

            player.Print();

            player.OpenInventory();

            //party memebers
            Charater party1 = new Charater("Chie");
            Charater party2 = new Charater("Futaba");
            party1.Print();
            Console.WriteLine("");
            party2.Print();

            //inventory menu selection
            while (choice != "0")
            {
                
                Console.WriteLine("\nWhose inventory?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + party1.Name());
                Console.WriteLine("3: " + party2.Name());
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    player.OpenInventory();
                }

                else if (choice == "2")
                {
                    party1.OpenInventory();
                }

                else if (choice == "3")
                {
                    party2.OpenInventory();
                }

                if (choice == "1")
                {
                    player = new Knight(name);
                }
                else if (choice == "2")
                {
                    player = new Rogue(name);
                }
                else
                {
                    player = new Charater(name);
                }
            }

            //EXP gains
            player.EXP = 30;
            player.EXP = player.EXP = 50;
            player.EXP++;
            player.EXP += 40;

            //Arrays
            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };

            string[] stringArray = new string[3];

            Charater[] party = { player, party1, party2, new Charater("Lonk") };

            Console.ReadKey();
        }
    }




}
       


    
