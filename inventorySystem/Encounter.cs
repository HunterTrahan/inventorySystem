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
        private Monster[] _evilMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _badMonsters = team1;
            _evilMonsters = team2;
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

            //Evil Team
            for (int i = 0; i < _evilMonsters.Length; i++)
            {
                Monster currentMonster = _evilMonsters[i];
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
                currentMonster.Fight(_evilMonsters);

               
            }

            for (int i = 0; i < _evilMonsters.Length; i++)
            {
                //Iterate through evil monsters
                //Have the cuurent evil monsters fight the first bad Monster
                Monster currentMonster2 = _evilMonsters[i];
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
                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Monster currentMonster = _badMonsters[1];
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

                //check if team 2 is alive
                bool evilAlive = true;

                for (int i = 0; i < _evilMonsters.Length; i++)
                {
                    Monster currentMonster = _evilMonsters[1];
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
