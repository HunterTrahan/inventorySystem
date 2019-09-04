using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                Console.WriteLine("2: Search");
                Console.WriteLine("3: Save");
                Console.WriteLine("4: Load");

               choice = Console.ReadLine();

                //Get player choice
                if (choice == "1")
                {
                    Travel();
                }

                else if (choice == "2")
                {
                    search();
                }

                else if (choice == "3")
                {
                    Save("save.txt");
                }

                else if (choice == "4")
                {
                    Load("save.txt");
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


        public void search()
        {
            //If the current scene is valide
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //search the room
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
        }


        //Save and Load system
        public void Save(string path)
        {
            //Create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //Write to it the same way we write to thye console
            writer.WriteLine(CurrentSceneID);
            //Close it
            writer.Close();
        }

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                //Create a reader object for the file at our path
                StreamReader reader = File.OpenText(path);
                //Write to it the same way we read from the console
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                //Close it
                reader.Close();
            }

            else
            {
                Console.WriteLine("Save file not found.");
            }
            
        }
    }
}
