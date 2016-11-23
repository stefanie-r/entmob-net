using StarWarsCross.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCross.Navigation
{
    public class NavigationService : INavigationService
    {
        public void NavigateTo(string pageKey)
        {
            if (pageKey == "Planets")
            {
                App.Current.MainPage = new PlanetsView();
            }
        }
    }
}
