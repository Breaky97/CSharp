using Newtonsoft.Json;
using System;
using System.IO;
using TextBasedGame.Adventures;

namespace TextBasedGame.Game
{
    public class GameService
    {
        public void StartGame()
        {
            Console.Clear();
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initalJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initalJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                }

                Console.WriteLine($"Adventure: {initialAdventure.Title} ");
                Console.WriteLine($"Description: {initialAdventure.Description}");
            }

            Console.WriteLine("\nYou started a game.");
        }
    }
}
