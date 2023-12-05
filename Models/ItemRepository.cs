using Microsoft.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext) 
        { 
            _appDbContext = appDbContext; 
        }

        public IEnumerable<Item> AllItems 
        { 
            get
            {
                return _appDbContext.Items.Include(c => c.Category);
            }
        }
        public IEnumerable<Item> ItemsOfTheWeek 
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category).Where(p => p.IsItemOfTheWeek);
            }
        }
        public Item? GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(p => p.ItemId == itemId);
        }
    }
}
