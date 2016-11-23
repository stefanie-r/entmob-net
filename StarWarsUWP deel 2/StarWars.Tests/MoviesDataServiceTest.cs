using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using StarWars.DAL;
using StarWars.Tests.Mocks;
using StarWarsUWP.Services;

namespace StarWars.Tests
{
    [TestClass]
    public class MoviesDataServiceTest
    {
        private IStarWarsRepository repository;
        [TestInitialize]
        public void Init()
        {
            repository = new MockRepository();
        }

        [TestMethod]
        public void getMovieDetailsTest()
        {
            var service = new SWMovieService(repository);
            var movie = service.GetMovie("testurl");
            Assert.IsNotNull(movie);
        }
    }
}
