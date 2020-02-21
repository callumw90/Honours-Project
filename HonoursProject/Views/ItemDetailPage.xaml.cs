using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

using HonoursProject.Models;
using HonoursProject.ViewModels;

namespace HonoursProject.Views
{

    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : TabbedPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();


            //var stringHTML = "<meta name=\"viewport\" content=\"initial-scale=1.0\" />" + viewModel.Property.short_description;

            //webView.Html = stringHTML;

            var mapView = new MapView(viewModel);
            var floorPlan = new FloorPlan(viewModel);
            this.Children.Add(floorPlan);
            this.Children.Add(mapView);

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Listing
            {
                displayable_address = "Item 1",
                details_url = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}