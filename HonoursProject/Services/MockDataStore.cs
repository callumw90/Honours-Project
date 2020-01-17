using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HonoursProject.Models;
using Microsoft.AppCenter.Data;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace HonoursProject.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {

            items = new List<Item>()
                {
                    new Item { id = Guid.NewGuid().ToString(), glass = "Martini", garnish = "Orange Peel", ingredients = new Ingredient{ unit }, name = "Flaming Homer", preparation = "This is an item description.", imageUri = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Flaming_cocktails.jpg"}
                };
            //Analytics.TrackEvent("List Loaded");
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.id == item.id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}