using System;
using System.Collections.Generic;
using HonoursProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Newtonsoft.Json;
using HonoursProject.Services;
using System.Threading.Tasks;
using System.Net;
using Launcher = Xamarin.Essentials.Launcher;

namespace HonoursProject.Views
{
    public partial class MapView : ContentPage
    {
        private ItemDetailViewModel viewModel;
        private Xamarin.Essentials.Location initLocation;

        public MapView(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            
            BindingContext = this.viewModel = viewModel;

            Map map = new Map(MapSpan.FromCenterAndRadius(new Position(viewModel.Property.latitude, viewModel.Property.longitude), Distance.FromMiles(1)));

            map.IsShowingUser = true;

            var pin = new Pin()
            {
                Position = new Position(viewModel.Property.latitude, viewModel.Property.longitude),
                Label = viewModel.Property.displayable_address
            };

            map.Pins.Add(pin);

            pin.InfoWindowClicked += Button_Clicked;

            Console.WriteLine(initLocation);

            Content = map;
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {

           string url = "";

            if(Device.RuntimePlatform == Device.iOS)
            {
                url = "http://maps.apple.com/maps?daddr=" + viewModel.Property.displayable_address + "&dirflg=d&t=h";
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                url = "https://www.google.com/maps/dir/?api=1&destination=" + viewModel.Property.latitude + "," + viewModel.Property.longitude;
            }

            await Launcher.TryOpenAsync(url);
        }
    }
}