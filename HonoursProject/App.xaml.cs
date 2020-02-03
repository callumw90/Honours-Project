using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HonoursProject.Services;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
using System.Threading;
using System.Globalization;
using System.Diagnostics;
using Microsoft.AppCenter.Data;
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
            AppCenter.Start("ios=15e896a5-7440-4fdb-9c77-cee3774eed52;" +
                  "uwp={Your UWP App secret here};" +
                  "android=845dd9ce-08aa-4f9a-994e-d072a95c8587",
                  typeof(Analytics), typeof(Data), typeof(Crashes), typeof(Push));

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
