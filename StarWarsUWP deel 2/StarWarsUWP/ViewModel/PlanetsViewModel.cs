using StarWars.DAL;
using StarWars.Domain;
using StarWarsUWP.Services;
using StarWarsUWP.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUWP.ViewModel
{
    public class PlanetsViewModel: INotifyPropertyChanged
    {

        private SWMovie selectedSWMovie;
        private ObservableCollection<SWPlanet> swPlanets;

        private PlanetService planetService;

        public PlanetsViewModel(PlanetService planetService)
        {
            this.planetService = planetService;
            Messenger.Default.Register<SWMovie>(this, OnSelectedMovieRecieved);
        }

        private void OnSelectedMovieRecieved(SWMovie movie)
        {
            SelectedSWMovie = movie;
            //SWPlanets = new ObservableCollection<SWPlanet>(planetService.AllPlanets(movie));
        }

        public SWMovie SelectedSWMovie
        {
            get
            {
                return selectedSWMovie;
            }
            set
            {
                selectedSWMovie = value;
                RaisePropertyChanged("SelectedSWMovie");
            }
        }

        public ObservableCollection<SWPlanet> SWPlanets {
            get
            {
                return swPlanets;
            }
            set
            {
                swPlanets = value;
                RaisePropertyChanged("SWPlanets");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
