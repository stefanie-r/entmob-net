using StarWars.DAL;
using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUWP.app.Service
{
    class MovieService : IMovieService
    {

        IStarWarsRepository repository;

        public MovieService(IStarWarsRepository repository)
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

