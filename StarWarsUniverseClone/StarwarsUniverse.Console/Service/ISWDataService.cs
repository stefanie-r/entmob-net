using StarwarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverse.Clone.Service
{
    interface ISWDataService
    {
        List<SWMovie> GetAllSWMovies();
        SWMovie GetSWMovieDetails(string uri);
    }
}
