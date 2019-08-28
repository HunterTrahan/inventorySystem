using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Encounter
    {
        private Monster[] _badMonsters;
        private Monster[] _goodMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _badMonsters = team1;
            _goodMonsters = team2;
        }

        public void Print()
        {
            //Iterate through badMonster and print
            //Bad Team
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
            }

            //Good Team
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
        }

        public void BeginRound()
        {
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                //Iterate through bad monsters
                //Have the cuurent bad monsters fight the first evil Monster
                Monster currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);

               
            }

            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                //Iterate through evil monsters
                //Have the cuurent evil monsters fight the first bad Monster
                Monster currentMonster2 = _goodMonsters[i];
                currentMonster2.Fight(_badMonsters);
            }
        }

        public void Start()
        {
            Console.WriteLine("\nEnciunter Start!");
            bool stillFighting = true;

            while (stillFighting)
            {
                //check if team 1 is alive
                bool badAlive = true;
                int totalBadHealth = 0;
                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Monster currentMonster = _badMonsters[1];
                    //total up the health of each monster
                    totalBadHealth += currentMonster.Health;
                }

                badAlive = totalBadHealth > 0;

                //check if team 2 is alive
                bool evilAlive = true;

                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Monster currentMonster = _goodMonsters[1];
                    if (currentMonster.Health > 0)
                    {
                        evilAlive = true;
                        break;
                    }

                    else if (currentMonster.Health <= 0)
                    {
                        evilAlive = false;
                    }
                }


                //if both teams are alive
                if (badAlive && evilAlive)
                {
                    //fight
                    stillFighting = true;
                    BeginRound();
                }

                else
                {
                    //stop
                    stillFighting = false;
                }
            }
        }

    }
}
