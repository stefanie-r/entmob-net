using StarWarsCross.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StarWarsCross.Views
{
    public partial class PlanetsView : CarouselPage
    {
        private PlanetsViewModel vm;
        public PlanetsView()
        {
            InitializeComponent();
            var locator = (App.Current as App).ViewModelLocator;
            vm = locator.Planets;
            vm.PropertyChanged += OnMovieChanged;
        }
        private void OnMovieChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(vm.SelectedSWMovie))
            {
                CreateOnePlanetViews();
            }
        }
        private void CreateOnePlanetViews()
        {
            Children.Clear();
            foreach (var planet in vm.SWPlanets)
            {
                Children.Add(new OnePlanetView()
                {
                    BindingContext = planet
                });
            }
        }
    }
}
