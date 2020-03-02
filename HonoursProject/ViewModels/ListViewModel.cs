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


        public void Sort(ObservableCollection<Listing> Items, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(Items, low, high);

                //use recursion to sort the array
                Sort(Items, low, partitionIndex - 1);
                Sort(Items, partitionIndex + 1, high);
            }
        }

        private int Partition(ObservableCollection<Listing> Items, int low, int high)
        {
            //select pivot in this case we choose the last element
            int pivot = high;

            int lowIndex = (low - 1);

            // re-order list
            for (int j = low; j < high; j++)
            {
                if (Items[j].price <= Items[pivot].price)
                {
                    lowIndex++;

                    Listing temp = Items[lowIndex];

                    Items[lowIndex] = Items[j];
                    Items[j] = temp;
                }
            }

            Listing temp1 = Items[lowIndex + 1];
            Items[lowIndex + 1] = Items[high];
            Items[high] = temp1;

            return lowIndex + 1;
        }

    }
}
