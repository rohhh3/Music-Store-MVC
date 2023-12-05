using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemsOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Item> itemsOfTheWeek) 
        {
            ItemsOfTheWeek = itemsOfTheWeek;
        }
    }
}
