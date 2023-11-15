namespace MusicStore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryId = 1, Name = "Guitars/Basses" },
                new Category{ CategoryId = 2, Name = "Keys" },
                new Category{ CategoryId = 3, Name = "Drums" },
                new Category{ CategoryId = 4, Name = "Studio" },
                new Category{ CategoryId = 5, Name = "Microphones" },
                new Category{ CategoryId = 6, Name = "Software" },
                new Category{ CategoryId = 7, Name = "Accessories" },
            };
    }
}
