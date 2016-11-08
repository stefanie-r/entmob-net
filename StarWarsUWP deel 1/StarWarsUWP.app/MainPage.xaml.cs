using StarWars.DAL;
using StarWars.Domain;
using StarWarsUWP.app.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StarWarsUWP.app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private ObservableCollection<SWMovie> swMovies;
        private SWMovie selectedSWMovie;

        private MovieService movieService;

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
                RaisePropertyChanged("selectedSWMovie");
            }
        }
        public MainPage()
        {
            this.InitializeComponent();
            movieService = new MovieService(new SWAPIRepository());
            var movies = movieService.AllMovies();
            SWMovies = new ObservableCollection<SWMovie>(movies);
            selectedSWMovie = swMovies.First();
            this.DataContext = SelectedSWMovie;
            moviesList.ItemsSource =SWMovies;
        }
        private bool CanRateUp()
        {
            if (SelectedSWMovie != null)
            {
                return SelectedSWMovie.Rating < 10.5;
            }
            return false;
        }

        private bool CanRateDown()
        {
            if (SelectedSWMovie != null)
            {
                return SelectedSWMovie.Rating > 0;
            }
            return false;
        }
        private void RateUp()
        {
            SelectedSWMovie.Rating += 0.5;
        }
        private void RateDown()
        {
            SelectedSWMovie.Rating -= 0.5;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedSWMovie = e.AddedItems[0] as SWMovie;
            if (e != null)
            {
                this.DataContext = SelectedSWMovie;
            }
        }

        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            if (CanRateUp() == true)
            {
                RateUp();
            }
        }

        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            if(CanRateDown() == true)
            {
                RateDown();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName]string prop="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
