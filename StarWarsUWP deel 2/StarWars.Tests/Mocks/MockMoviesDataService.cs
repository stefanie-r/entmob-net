using StarWarsUWP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Domain;

namespace StarWars.Tests.Mocks
{
    class MockMoviesDataService : MovieService
    {
        private MockRepository repository = new MockRepository();

        public List<SWMovie> AllMovies()
        {
            return repository.GetAllSWMovies();
        }

        public SWMovie GetMovie(string url)
        {
            return repository.GetMovieByUrl("mockurl");
        }
    }
}
