using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;
        private Creature[] _enemies;
        private bool _cleared = false;


        public Scene(string name, int northID, int southID, int eastID, int westID, Creature[] enemies, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = "Nothing of intrest.";
            if (_enemies.Length == 0)
            {
                _cleared = true;
            }
        }

        public Scene(string name, int northID, int southID, int eastID, int westID, Creature[] enemies, string description, string hidden)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = hidden;
        }

        //Return the name
        public string GetName()
        {
            return _name;
        }

        //Return the description
        public string GetDescription()
        {
            return _description;
        }

        public bool GetCleared()
        {
            return _cleared;
        }

        public Creature[] GetEnemies()
        {
            return _enemies;
        }

        public int ChooseExit()
        {
            string choice = "";
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {
                //Ask the player whicj way to go
                Console.WriteLine("Which direction would you like to go? (N/S/E/W)");
                choice = Console.ReadLine();

                //Set choice to caps
                choice = choice.ToUpper();
            }

            //return the integer ID of that direction
            if (choice == "N")
            {
                return _north;
            }

            else if (choice == "S")
            {
                return _south;
            }

            else if (choice == "E")
            {
                return _east;
            }

            else if (choice == "W")
            {
                return _west;
            }
            
            else
            {
                //If we have an invalid choice, we return -1
                //We make sure the Map does not travel to -1
                return -1;
            }
        }

        public string GetHidden()
        {
            return _hidden;
        }

    }
}
