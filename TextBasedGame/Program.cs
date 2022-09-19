using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.WebSockets;
using TextBasedGame.Adventures;
using TextBasedGame.Game;

namespace TextBasedGame
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args)
        {
            //MakeTitle();
            MainMenu();
        }



        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("***************************************************");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("*      ┌─┐┌─┐┌┐┌┌─┐┌─┐┬  ┌─┐  ┌─┐┬─┐┌─┐┬ ┬┬       *");
            Console.WriteLine("*      │  │ ││││└─┐│ ││  ├┤   │  ├┬┘├─┤││││       *");
            Console.WriteLine("*      └─┘└─┘┘└┘└─┘└─┘┴─┘└─┘  └─┘┴└─┴ ┴└┴┘┴─┘     *");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("***************************************************");
        }
        private static void MainMenu()
        {
            MakeTitle();
            MeneChoices();
            bool inputValid = false;

            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        inputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        inputValid = true;
                        break;
                    case "C":
                        CrateCharacter();
                        inputValid = true;
                        break;
                    default:

                        Console.Clear();
                        MakeTitle();
                        Console.WriteLine("Invalid input please try again.");
                        MeneChoices();
                        break;
                }
            }
        }

        private static void MeneChoices()
        {
            Console.WriteLine("\n\n\n\n(S)tart new game.\n");
            Console.WriteLine("(L)oad new game.\n");
            Console.WriteLine("(C)reate new character.\n");
        }



        private static void CrateCharacter()
        {
            Console.Clear();
            Console.WriteLine("\nYou are creating a character.");
        }

        private static void LoadGame()
        {
            Console.Clear();
            Console.WriteLine("\nLoading game... please standby...");
        }
    }

}
