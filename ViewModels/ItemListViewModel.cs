using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; }
        public string? CurrentCategory { get; }
        public string? CategoryImageUrl { get; set; }
        public string? CategoryName { get; set; }   

        public ItemListViewModel(IEnumerable<Item> items, string? currentCategory, string? categoryImageUrl, string? categoryName)
        {
            Items = items;
            CurrentCategory = currentCategory;
            CategoryImageUrl = categoryImageUrl;
            CategoryName = categoryName;
        }
    }
}
