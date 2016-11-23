using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using StarWars.DAL;
using StarWars.Tests.Mocks;
using StarWarsUWP.Services;
using StarWarsUWP.ViewModel;
using System.Collections.ObjectModel;
using StarWars.Domain;

namespace StarWars.Tests
{
    [TestClass]
    class MoviesViewModelTest
    {
        private MovieService movieService;

        private StarWarsMoviesViewModel getViewModel()
        {
            return new StarWarsMoviesViewModel(this.movieService);
        }
        [TestInitialize]
        public void Init()
        {
            movieService = new MockMoviesDataService();
        }

        [TestMethod]
        public void LoadAllMovies()
        {
            //Arrange
            ObservableCollection<SWMovie> movies = null;
            var expectedMovies = movieService.AllMovies();

            //act
            var viewModel = getViewModel();
            movies = viewModel.SWMovies;      

            //assert
            CollectionAssert.AreEqual(expectedMovies, movies);
        }
    }
}
