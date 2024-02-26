using MusicStore.Models;

namespace MusicStore.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
