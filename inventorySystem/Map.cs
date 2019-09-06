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
        private int _currentLocation = 0;   //ID of the cuurent scene
        private Scene[] _sceneList;     //List of all the scenes on the map
        private Creature[] _players;

        public Map(int startingSceneID, Scene[] scenes, Creature[] players)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
            _players = players;
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
                Console.WriteLine("0: Quit");
                Console.WriteLine("1: Inventory");
                Console.WriteLine("2: Travel");
                Console.WriteLine("3: Stats");
                Console.WriteLine("4: Search");
                Console.WriteLine("5: Save");
                Console.WriteLine("6: Load");

               choice = Console.ReadLine();

                //Get player choice
                if (choice == "1")
                {
                    Console.WriteLine("Whos Inventory?");
                    Console.WriteLine("1: Aigis");
                    Console.WriteLine("2: Chie");

                    string choice2 = Console.ReadLine();

                    if (choice2 == "1")
                    {
                        ((Charater)_players[0]).OpenInventory();
                    }

                    else if (choice2 == "2")
                    {
                        ((Charater)_players[1]).OpenInventory();
                    } 
                }

                else if (choice == "2")
                {
                    Travel();
                }

                else if (choice == "3")
                {
                    ((Charater)_players[0]).Print();
                    ((Charater)_players[1]).Print();
                }

                else if (choice == "4")
                {
                    search();
                }

                else if (choice == "5")
                {
                    Save("save.txt");
                }

                else if (choice == "6")
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
            CheckForCreature();
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

        
        public void CheckForCreature()
        {
            //If current scene is valid
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //check the current scene
                Scene currentScene = _sceneList[_currentLocation];
                if (currentScene.GetCleared() == false)
                {
                    //fight
                    Encounter encounter = new Encounter(_players, currentScene.GetEnemies());
                    encounter.Start();
                }
            }
        }


        //Save and Load system
        public void Save(string path)
        {
            //Create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //Write to it the same way we write to thye console
            writer.WriteLine(CurrentSceneID);
            ((Charater)_players[0]).Save(writer);
            ((Charater)_players[1]).Save(writer);
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
