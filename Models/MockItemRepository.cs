using Humanizer;
using Microsoft.AspNetCore.Razor.Language;

namespace MusicStore.Models
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> AllItems =>
            new List<Item>
            {
                new Item 
                {
                    ItemId = 1, Name = "Fender Stratocaster", Price = 1100M, 
                    Description = "The Fender Stratocaster, colloquially known as " +
                    "the Strat, is a model of electric guitar designed from 1952 into 1954 by Leo Fender, " +
                    "Bill Carson, George Fullerton and Freddie Tavares. The Fender Musical Instruments Corporation has " +
                    "continuously manufactured the Stratocaster from 1954 to the present. It is a double-cutaway guitar, " +
                    "with an extended top horn for balance while standing. Alongside the Gibson Les Paul, it is one of the " +
                    "most-often emulated electric guitar shapes. \"Stratocaster\" and \"Strat\" are trademark terms belonging " +
                    "to Fender.", Category = _categoryRepository.AllCategories.ToList()[0], 
                    ImageUrl = "https://riff.net.pl/108249-large_default/fender-player-stratocaster-mn-3ts.jpg", 
                    InStock = true, IsItemOfTheWeek = true, 
                    ImageThumbnailUrl = "https://riff.net.pl/108249-large_default/fender-player-stratocaster-mn-3ts.jpg"
                },
                new Item
                {
                    ItemId = 2, Name = "Yamaha P124 PE", Price = 1800M,
                    Description = "The Yamaha P124 PE is a 48  professional upright piano. Like all Yamaha pianos, " +
                    "the P124 PE is built to a high standard to ensure that it will provide many years of good service. " +
                    "The P124 PE is a popular choice for schools and teaching studios, and is also suitable for the home. " +
                    "The P124 PE is finished in polished ebony, and is also available in polished mahogany and polished white. " +
                    "The P124 PE is also available with the " +
                    "Yamaha Silent system, which allows the piano to be played silently using headphones.",
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    ImageThumbnailUrl = "https://www.nordpiano.pl/media/products/1a61ea995c4990f15247d3a9f0610f2c/images/thumbnail/large_284.jpg?lm=1683121444",
                    ImageUrl = "https://www.nordpiano.pl/media/products/1a61ea995c4990f15247d3a9f0610f2c/images/thumbnail/large_284.jpg?lm=1683121444",
                    InStock = true, IsItemOfTheWeek = true
                }
            };


        public IEnumerable<Item> ItemsOfTheWeek
        {
            get
            {
                return AllItems.Where(p => p.IsItemOfTheWeek);
            }
        }

        public Item? GetItemById(int itemId) => AllItems.FirstOrDefault(p => p.ItemId == itemId);

        public IEnumerable<Item> SearchItems(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
