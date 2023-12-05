namespace MusicStore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryId = 1, CategoryName = "Guitars/Basses" },
                new Category{ CategoryId = 2, CategoryName = "Keys" },
                new Category{ CategoryId = 3, CategoryName = "Drums" },
                new Category{ CategoryId = 4, CategoryName = "Studio" },
                new Category{ CategoryId = 5, CategoryName = "Microphones" },
                new Category{ CategoryId = 6, CategoryName = "Software" },
                new Category{ CategoryId = 7, CategoryName = "Accessories" },
            };
    }
}
