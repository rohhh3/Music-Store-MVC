namespace MusicStore.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item? GetItemById(int itemId);
    }
}
