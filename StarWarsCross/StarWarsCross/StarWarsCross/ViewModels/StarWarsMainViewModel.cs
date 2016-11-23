using StarWars.Domain;
using StarWarsCross.Navigation;
using StarWarsCross.Services;
using StarWarsCross.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCross.ViewModel
{
    public class StarWarsMoviesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<SWMovie> swMovies;
        private SWMovie selectedSWMovie;

        private MovieService movieService;

        public CustomCommand RateUpCommand { get; set; }
        public CustomCommand RateDownCommand { get; set; }
        public CustomCommand LoadCommand { get; set; }
        public CustomCommand ShowPlanetsCommand { get; set; }

        public StarWarsMoviesViewModel(MovieService movieService)
        {
            this.movieService = movieService;
            LoadCommands();
        }

        private void LoadCommands()
        {
            RateDownCommand = new CustomCommand(RateDown, CanRateDown);
            RateUpCommand = new CustomCommand(RateUp, CanRateUp);
            LoadCommand = new CustomCommand(Load, CanLoad);
            ShowPlanetsCommand = new CustomCommand(ShowPlanets, CanShowPlanets);
        }

        public ObservableCollection<SWMovie> SWMovies
        {
            get
            {
                return swMovies;
            }
            set
            {
                swMovies = value;
                RaisePropertyChanged("SWMovies");
            }
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
                RateDownCommand.RaiseCanExecuteChanged();
                RateUpCommand.RaiseCanExecuteChanged();
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool CanRateUp(object obj)
        {
            if (selectedSWMovie != null)
            {
                return selectedSWMovie.Rating < 10;
            }
            return false;
        }

        private bool CanRateDown(object obj)
        {
            if (selectedSWMovie != null)
            {
                return selectedSWMovie.Rating > 0;
            }
            return false;
        }

        private bool CanLoad(object obj)
        {
            return true;
        }

        private bool CanShowPlanets(object obj)
        {
            if (selectedSWMovie != null)
            {
                return true;
            }
            return false;
        }

        private void RateUp(object obj)
        {
            SelectedSWMovie.Rating += 0.5;
            RateDownCommand.RaiseCanExecuteChanged();
            RateUpCommand.RaiseCanExecuteChanged();
        }

        private void RateDown(object obj)
        {
            SelectedSWMovie.Rating -= 0.5;
            RateDownCommand.RaiseCanExecuteChanged();
            RateUpCommand.RaiseCanExecuteChanged();
        }

        private void Load(object obj)
        {
            var movies = movieService.AllMovies();
            SWMovies = new ObservableCollection<SWMovie>(movies);
        }

        private void ShowPlanets(object obj)
        {
            Messenger.Default.Send<SWMovie>(selectedSWMovie);
            new NavigationService().NavigateTo("Planets");
        }
    }
}
