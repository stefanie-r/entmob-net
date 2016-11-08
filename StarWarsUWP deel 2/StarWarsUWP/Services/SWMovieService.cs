using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.DAL;
using StarWars.Domain;

namespace StarWarsUWP.Services
{
    public class SWMovieService: MovieService
    {

        IStarWarsRepository repository;

        public SWMovieService(IStarWarsRepository repository)
        {
            this.repository = repository;
        }

        public List<SWMovie> AllMovies()
        {
            return repository.GetAllSWMovies().OrderBy(m => m.Episode_ID).ToList();
        }

        public SWMovie GetMovie(string url)
        {
            return repository.GetMovieByUrl(url);
        }
    }
}
