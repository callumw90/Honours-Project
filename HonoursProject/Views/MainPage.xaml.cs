using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter.Analytics;

using HonoursProject.Services;
using HonoursProject.ViewModels;
using HonoursProject.Models;
using HonoursProject.Views;


namespace HonoursProject.Views
{

    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {

        ListViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ListViewModel();

            var propertyMap = new PropertyMap(viewModel);

            Children.Add(propertyMap);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Listing; // get selected item

            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));


            ListingListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if(viewModel.Items.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }

         void Sort_list(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("Sorting List");

            int length = viewModel.Items.Count;

            viewModel.Sort(viewModel.Items, 0, length - 1);
        }
    }
}
