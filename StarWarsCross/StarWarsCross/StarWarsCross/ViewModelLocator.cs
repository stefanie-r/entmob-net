using StarWars.DAL;
using StarWarsCross.Services;
using StarWarsCross.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCross
{
    public class ViewModelLocator
    {

        private static MovieService movieService = new SWMovieService(new SWAPIRepository());
        private static PlanetService planetService = new SWPlanetService(new SWAPIRepository());

        private static StarWarsMoviesViewModel starWarsMoviesViewModel = new StarWarsMoviesViewModel(movieService);

        public static StarWarsMoviesViewModel StarWarsMoviesViewModel
        {
            get
            {
                return starWarsMoviesViewModel;
            }
        }

        private static PlanetsViewModel planetsViewModel = new PlanetsViewModel(planetService);

        public static PlanetsViewModel PlanetsViewModel
        {
            get
            {
                return planetsViewModel;
            }
        }

        public PlanetsViewModel Planets { get; internal set; }
    }
}
