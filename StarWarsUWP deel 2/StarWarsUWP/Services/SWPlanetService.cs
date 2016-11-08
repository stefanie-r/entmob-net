using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Domain;
using StarWars.DAL;

namespace StarWarsUWP.Services
{
    class SWPlanetService : PlanetService
    {

        IStarWarsRepository repository;

        public SWPlanetService(IStarWarsRepository repository)
        {
            this.repository = repository;
        }

        public List<SWPlanet> AllPlanets(SWMovie movie)
        {
            return repository.GetAllSWPlanets(movie);
        }
    }
}
