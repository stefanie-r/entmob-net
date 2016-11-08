using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUWP.app.Service
{
    public interface IMovieService
    {

        SWMovie GetMovie(string url);
        List<SWMovie> AllMovies();

    }
}
