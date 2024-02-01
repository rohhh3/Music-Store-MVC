using MusicStore.Models;
using Microsoft.AspNetCore.Components;
using MusicStore.Services;

namespace MusicStore.Pages.App
{
    public partial class SearchBlazor
    {
        public string SearchText = "";
        public List<Item> FilteredItems { get; set; } = new List<Item>();

        [Inject]
        public IItemRepository? ItemRepository { get; set; }

        private void Search()
        {
            FilteredItems.Clear();
            if (ItemRepository is not null)
            {
                if (SearchText.Length >= 3)
                    FilteredItems = ItemRepository.SearchItems(SearchText).ToList();
            }
        }
    }
}
