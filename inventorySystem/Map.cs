using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorySystem
{
    class Map
    {
        private int _currentLocation;   //ID of the cuurent scene
        private Scene[] _sceneList;     //List of all the scenes on the map

        public Map(int startingSceneID, Scene[] scenes)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
        }

        public void PrintCurrentScene()
        {
            //If current scene ID is within range
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //Print the current scene's name & description
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID");
            }
        }

        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }

            set
            {
                //If value is on the map
                if (value >= 0 && value < _sceneList.Length)
                {
                    //Change to the new scene
                    _currentLocation = value;
                }

                //otherwise
                else
                {
                    //print error
                    Console.WriteLine("\nInvalid scene ID");
                }
            }
        }

        public void Menu()
        {
            string choice = "";

            while (choice != "0")
            {
                //let the player know location
                PrintCurrentScene();
                //Print menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");

               choice = Console.ReadLine();

                //Get player choice
                if (choice == "1")
                {
                    Travel();
                }
            }
        }

        public void Travel()
        {
            int destination = -1;

            //If the current scene is valide
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //ask the player where to go
                destination = _sceneList[_currentLocation].ChooseExit();
            }

            //If the destination is on map
            if (destination >= 0 && destination < _sceneList.Length)
            {
                //go there
                CurrentSceneID = destination;
            }
            //Otherwise
            else
            {
                //Tell the player thet cannot
                Console.WriteLine("There is nothing in that direction");
            }
        }
    }
}
