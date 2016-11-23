using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCross.Services
{
        public interface PlanetService
        {

            List<SWPlanet> AllPlanets(SWMovie movie);
        }
    
}
