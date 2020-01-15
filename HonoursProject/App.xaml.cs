using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HonoursProject.Services;
using HonoursProject.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
using System.Threading;
using System.Diagnostics;
using Microsoft.AppCenter.Data;

namespace HonoursProject
{
    public partial class App : Application
    {

        

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=15e896a5-7440-4fdb-9c77-cee3774eed52;" +
                  "uwp={Your UWP App secret here};" +
                  "android=845dd9ce-08aa-4f9a-994e-d072a95c8587",
                  typeof(Analytics), typeof(Data), typeof(Crashes), typeof(Push));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
