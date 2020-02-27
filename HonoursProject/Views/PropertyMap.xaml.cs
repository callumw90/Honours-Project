using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HonoursProject.Models;
using HonoursProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HonoursProject.Views
{
    public partial class PropertyMap : ContentPage
    {
        ListViewModel viewModel;

        public PropertyMap (ListViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        protected void loadPins()
        {
            PropMap.Pins.Clear();

            for (int i = 0; i < viewModel.Items.Count; i++)
            {
                var pin = new Pin()
                {
                    Position = new Position(viewModel.Items[i].latitude, viewModel.Items[i].longitude),
                    Label = viewModel.Items[i].displayable_address,
                    BindingContext = viewModel.Items[i]
                };

                pin.InfoWindowClicked += (sender, args) =>
                {
                    Listing listing = (Listing)((Pin)sender).BindingContext;

                    Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(listing)));
                };

                PropMap.Pins.Add(pin);
            }

            PropMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(viewModel.Items[0].latitude, viewModel.Items[0].longitude), Distance.FromMiles(15)));
        }

        protected override void OnAppearing()
        {
            loadPins();
        }

    }
}
