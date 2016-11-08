using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace StarWarsUWP.Services
{
    public class NavigationService
    {

        public void NavigateTo(string key)
        {
            if(key == "Planets")
            {
                PlanetsView view = new PlanetsView();
                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(PlanetsView));
            }
        }
    }
}
