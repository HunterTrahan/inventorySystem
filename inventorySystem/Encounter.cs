using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Encounter
    {
        private Creature[] _badMonsters;
        private Creature[] _goodMonsters;

        public Encounter(Creature[] team1, Creature[] team2)
        {
            _badMonsters = team1;
            _goodMonsters = team2;
        }

        int GetTotalXP(Creature[] creatures)
        {
            int total = 0;
            for (int i = 0; i < creatures.Length; i++)
            {
                total += creatures[i].GetXP();
            }
            return total;
        }

        public void Print()
        {
            //Iterate through badMonster and print
            //Bad Team
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
                currentMonster.Print();
            }

            //Good Team
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
        }

        public void BeginRound()
        {
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                //Iterate through bad monsters
                //Have the cuurent bad monsters fight the first evil Monster
                Creature currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);

               
            }

            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                //Iterate through evil monsters
                //Have the cuurent evil monsters fight the first bad Monster
                Creature currentMonster2 = _goodMonsters[i];
                currentMonster2.Fight(_badMonsters);
            }
        }

        public void Start()
        {
            Console.WriteLine("\nEncounter Start!");
            bool stillFighting = true;

            while (stillFighting)
            {
                //check if team 1 is alive
                bool goodAlive = true;
                int totalGoodHealth = 0;
                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Creature currentMonster = _goodMonsters[i];
                    //total up the health of each monster
                    totalGoodHealth += currentMonster.Health;
                }

                goodAlive = totalGoodHealth > 0;

                //check if team 2 is alive
                bool badAlive = true;

                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Creature currentMonster = _badMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        badAlive = true;
                        break;
                    }

                    else if (currentMonster.Health <= 0)
                    {
                        badAlive = false;
                    }
                }


                //if both teams are alive
                if (goodAlive && badAlive)
                {
                    //fight
                    stillFighting = true;
                    BeginRound();
                }

                else
                {
                    //stop
                    stillFighting = false;
                    if (goodAlive)
                    {

                        //Give XP to each character in good team
                        //For each creature in good team
                        foreach (Creature cr in _goodMonsters)
                        {
                            //If that Creature is a character
                            if (cr is Charater)
                            {
                                //Give it XP from bad team
                                Charater ch = (Charater)cr;
                                ch.EXP += GetTotalXP(_badMonsters);
                            }
                        }
                    }
                }
            }
        }

    }
}
