using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCross.Services
{
    public interface MovieService
    {
        SWMovie GetMovie(string url);
        List<SWMovie> AllMovies();
    }
}
