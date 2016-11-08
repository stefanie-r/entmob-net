using StarWars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUWP.Services
{
    public interface PlanetService
    {

        List<SWPlanet> AllPlanets(SWMovie movie);
    }
}
