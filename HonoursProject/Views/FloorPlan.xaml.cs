using System;
using System.Collections.Generic;
using HonoursProject.ViewModels;
using Xamarin.Forms;

namespace HonoursProject.Views
{
    public partial class FloorPlan : ContentPage
    {

        private ItemDetailViewModel viewModel;

        public FloorPlan(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

            var images = viewModel.Property.floor_plan;

            MainView.ItemsSource = images;
        }
    }
}
