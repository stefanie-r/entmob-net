using StarWars.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Domain;

namespace StarWars.Tests.Mocks
{
    class MockRepository : IStarWarsRepository
    {
        private List<SWMovie> movies;
        private List<SWPlanet> planets;
        public MockRepository()
        {
            movies = LoadMockMovies();
        }

        private List<SWMovie> LoadMockMovies()
        {
            return new List<SWMovie>()
            {
                new SWMovie()
                {
                    Created = new DateTime(2014,1,3),
                    Edited = new DateTime(2014,1,4),
                    ResourceUri = "resourceUri",
                    Title = "titel1",
                    Episode_ID = 1,
                    OpeningCrawl = "openingscrawl1",
                    Director = "director",
                    Producer = "producer",
                    ReleaseDate = new DateTime(2014,1,5)
    },new SWMovie()
                {
                    Created = new DateTime(2015,1,3),
                    Edited = new DateTime(2015,1,4),
                    ResourceUri = "resourceUri2",
                    Title = "titel2",
                    Episode_ID = 1,
                    OpeningCrawl = "openingscrawl2",
                    Director = "director",
                    Producer = "producer",
                    ReleaseDate = new DateTime(2015,1,5)
    }
            };
        }

        public List<SWMovie> GetAllSWMovies()
        {
            return movies;
        }
        public SWMovie GetMovieByUrl(string url)
        {
            return movies.First();
        }
        public List<SWPlanet> GetAllSWPlanets(SWMovie movie)
        {
            throw new NotImplementedException();
        }
        public SWPlanet GetPlanetByUrl(string url)
        {
            throw new NotImplementedException();
        }
    }
}
