using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using HonoursProject.Models;
using HonoursProject.Services;
using HonoursProject.Views;

namespace HonoursProject.ViewModels
{
    public class ListViewModel : BaseViewModel
    {
        public ObservableCollection<Listing> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ListViewModel()
        {
            Title = "Property List";
            Items = new ObservableCollection<Listing>();

            LoadItemsCommand = new Command(async () => ExecuteLoadItemsCommand());

        }

        private async void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();

               var items = await GetData.Deserialize();

               foreach (Listing item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
