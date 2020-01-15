using System;

using HonoursProject.Models;

namespace HonoursProject.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item.CocktailName;
            Item = item;
        }
    }
}
