using MusicStore.Models;

namespace MusicStore.Services
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item? GetItemById(int itemId);
        IEnumerable<Item> SearchItems(string searchQuery);
        IEnumerable<Item> GetItemsByCategoryByName(string categoryName);
    }
}
