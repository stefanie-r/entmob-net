using StarWars.DAL;
using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCross.Services
{
    public class SWPlanetService : PlanetService
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
