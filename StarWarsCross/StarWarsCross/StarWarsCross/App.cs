using StarWarsCross.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StarWarsCross
{
    public partial class App : Application
    {
        private ViewModelLocator locator;
        public App()
        {
            locator = new ViewModelLocator();
            // The root page of your application
            MainPage = new StarWarsMainView();
        }

        public ViewModelLocator ViewModelLocator
        {
            get
            {
                return locator;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
