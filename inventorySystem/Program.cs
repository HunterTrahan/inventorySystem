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
            //Inventory inventory = new Inventory();
            //inventory.Menu();

            Charater player = new Charater("Aigis");
            player.Print();

            Charater party1 = new Charater("Chie");
            Charater party2 = new Charater("Futaba");
            party1.Print();
            party2.Print();

            player.EXP = 30;
            player.EXP = player.EXP = 50;
            player.EXP++;
            player.EXP += 40;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;
            player.EXP += 200;


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
       


    
