using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HonoursProject.Models;
using HonoursProject.Views;
using HonoursProject.ViewModels;
using HonoursProject.Services;

namespace HonoursProject.Views
{

    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;
        readonly Stopwatch beginSW = new Stopwatch();

        public ItemsPage()
        {
            InitializeComponent();

            beginSW.Start();
            Console.WriteLine("Running the StopWatch");

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {

            var item = args.SelectedItem as Item; //get the selected item

            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item))); //open page of the item thats been selected

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        /*public void GetCpuTime_Clicked(object sender, EventArgs e)
        {
            var proc = Process.GetCurrentProcess();
            Console.WriteLine("STATS|CPU={Cpu}%|Mem={Mem}", (int)(100 * proc.TotalProcessorTime.TotalMilliseconds / beginSW.ElapsedMilliseconds), proc.PeakWorkingSet64);
        }*/

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}