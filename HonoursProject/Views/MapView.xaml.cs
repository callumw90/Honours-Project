using System;
using System.Collections.Generic;
using HonoursProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HonoursProject.Views
{
    public partial class MapView : ContentPage
    {
        private ItemDetailViewModel viewModel;

        public MapView(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

            Map map = new Map(MapSpan.FromCenterAndRadius(new Position(viewModel.Property.latitude, viewModel.Property.longitude), Distance.FromMiles(1)));

            var pin = new Pin()
            {
                Position = new Position(viewModel.Property.latitude, viewModel.Property.longitude),
                Label = viewModel.Property.displayable_address
            };

            map.Pins.Add(pin);

            Content = map;
        }
    }
}
