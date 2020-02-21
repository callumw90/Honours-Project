using System;
using Xamarin.Forms;
using System.Globalization;
using HonoursProject.Views;

namespace HonoursProject
{
    public partial class App : Application
    {  
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new MainPage());
        }

        protected override void OnStart()
        {
            CultureInfo cultureInfo = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
