using System.Diagnostics;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
          

            var videoGames = new List<string>() 
            { 
                "Minecraft",
                "Super Mario Bros", 
                "Halo", 
                "The Last Of Us",
                "Zombies",
                "Resident Evil",
                "Grand Theft Auto",
                "Roblox",
                "Fortnite",
                "The Legend of Zelda"
            };

            var sortedGames = videoGames.OrderBy(x => x.Length).ToList();

            Console.WriteLine("Video games sorted by name length:");

            foreach(var game in sortedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
