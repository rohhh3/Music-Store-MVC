using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemsOfTheWeek { get; }
        public VisitCounter VisitCounter { get; }

        public HomeViewModel(IEnumerable<Item> itemsOfTheWeek, VisitCounter visitCounter)
        {
            ItemsOfTheWeek = itemsOfTheWeek;
            VisitCounter = visitCounter;
        }
    }
}
