using System;

namespace LINQ_Wixson_Hunter
{
  
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Game objects to represent various games.
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                // ... other games ...
            };

            // LINQ query to select game titles with fewer than 9 characters and convert them to uppercase.
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            // Iterate through the short games and print each title.
            foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

            // LINQ query to find the Minecraft game and select its title, ESRB, and genre.
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                                 .Select(Game => $"Title: {Game.Title}, ESRB: {Game.Esrb}, Genre: {Game.Genre}");


            // Print the Minecraft game information.
            Console.WriteLine(mineCraft.FirstOrDefault());

            // LINQ query to select titles of games with a 'T' rating.
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            // Print the 'T' rated games.
            Console.WriteLine("T Rated Games: ");
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

            // LINQ query to select titles of games with an 'E' rating and that contain "Action" in their genre.
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            // Print the 'E' rated action games.
            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}