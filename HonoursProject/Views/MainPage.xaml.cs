using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HonoursProject.Services;
using HonoursProject.ViewModels;
using HonoursProject.Models;
using HonoursProject.Views;


namespace HonoursProject.Views
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        ListViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ListViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Cocktails; // get selected item

            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));


            CocktailListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if(viewModel.Items.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }

        protected void UsageDataClicked(object sender, EventArgs args)
        {

            var totalMem = GCCollectClass.GetMemUsage();

            totalMem /= 1024;

            //totalMem.ToString();

            DisplayAlert("Total Memory in Use","Memory: " + totalMem + " MB","OK");
        }

    }
}
