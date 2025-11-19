using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        public static List<Game> games = new List<Game>()
        {
            new Game{Title = "Minecraft", Genre = "Adventure", ReleaseYear = 2009, Rating = 10, Price = 35},
            new Game{Title = "Minecraft2", Genre = "Adventure", ReleaseYear = 2010, Rating = 7, Price = 25},
            new Game{Title = "Minecraft3", Genre = "Adventure", ReleaseYear = 2011, Rating = 9, Price = 30},
            new Game{Title = "Minecraft4", Genre = "Adventure", ReleaseYear = 2012, Rating = 9, Price = 20},
            new Game{Title = "Minecraft5", Genre = "Adventure", ReleaseYear = 2013, Rating = 8, Price = 0}
        };

        static void Main(string[] args)
        {
            /*
            var cats = games.Select(g => g.Genre).Distinct();
            foreach (var c in cats)
            {
                Console.WriteLine(c);
            }
            */

            /*
            var cheapest = games.OrderBy(g => g.Price).First();
            Console.WriteLine(cheapest);
            */

            /*
            var cheapRpgGames = games.Where(g => g.Genre == "Adventure" && g.Price < 30).OrderByDescending(g => g.Rating).Select(g => $"{g.Title} {g.Price}");
            foreach (var game in cheapRpgGames)
            {
                Console.WriteLine(game);
            }
            */

            /*
            var groupByGenre = games.GroupBy(genre => genre.Genre);
            foreach (var group in groupByGenre)
            {
                Console.WriteLine(group.Key+":");

                foreach (var game in group)
                {
                    Console.WriteLine(game.Title);
                }
            }
            */

            /*
            var mostEx = games.Max(price => price.Price);
            Console.WriteLine(mostEx);

            var mostExpensive = games.First(game => game.Price == mostEx);
            Console.WriteLine(mostExpensive.Title);
            */

            /*
            var averagePrice = games.Average(price => price.Price);
            Console.WriteLine(averagePrice);
            */

            /*
            var sortedByYear = games.OrderBy(game  => game.ReleaseYear);
            foreach (var item in sortedByYear)
            {
                Console.WriteLine($"{item.Title} - {item.ReleaseYear}");
            }
            */

            /*
            var rpgGames = games.Where(game => game.Genre == "Adventure");
            */

            /*
            var existingGame = games.Any(game => game.ReleaseYear == 2010);
            */

            /*
            var gameTitles = games.Select(game => game.Title).ToList();

            foreach (var title in gameTitles)
            {
                Console.WriteLine(title);
            }
            */
        }
    }
}
