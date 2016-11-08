namespace StarwarsUniverse.DataLayer.Migrations
{
    using Model;
    using StarWarsUniverse.Clone.Service;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StarwarsUniverse.Clone.DataLayer.StarWarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StarwarsUniverse.Clone.DataLayer.StarWarsContext context)
        {
            SWDataService service = new SWDataService();
            List<SWMovie> movies = service.GetAllSWMovies();
            List<SWPlanet> planets = service.GetAllSWPlanets();

            foreach (SWPlanet planet in planets)
            {
                //planet.Films = (from movie in movies where movie.PlanetUris.Any(u => u == planet.ResourceUri) select movie).ToList();
                /*foreach (SWMovie movie in movies)
                 {
                     planet.Films.Add(movie);
                 }*/
               context.Planets.AddOrUpdate(s => s.ResourceUri, planet);
            }

           // context.SaveChanges();

            foreach (SWMovie movie in movies)
            {
               // movie.Planets = (from planet in planets where planet.FilmUris.Any(u => u == movie.ResourceUri) select planet).ToList();
               // Console.WriteLine(movie.Planets.Count);
                context.Movies.AddOrUpdate(s => s.ResourceUri, movie);
            }
            //context.SaveChanges();
            base.Seed(context);
            
        }
    }
}
