using StarwarsUniverse.Clone.DataLayer;
using StarwarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarwarsUniverse.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StarWarsContext();
            var movies = from movie in context.Movies orderby movie.Episode_ID select movie;

            Console.WriteLine("=== Star Wars Movies ===");
            foreach (SWMovie movie in movies)
            {
                Console.WriteLine(String.Format("{0} - {1}", movie.Episode_ID, movie.Title));
                Console.WriteLine("released: " + movie.ReleaseDate);
                foreach (SWPlanet planet in movie.Planets)
                {
                    Console.Write(planet.Name);
                }
            }
            Console.WriteLine("=========================");
            Console.ReadLine();
        }
    }
}
