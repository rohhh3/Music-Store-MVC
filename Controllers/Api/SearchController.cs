using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Services;

namespace MusicStore.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public SearchController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allItems = _itemRepository.AllItems;
            return Ok(allItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if(!_itemRepository.AllItems.Any(i => i.ItemId == id))
            {
                return NotFound();
            }
            return Ok(_itemRepository.AllItems.Where(i => i.ItemId == id));
        }

        [HttpPost]
        public IActionResult SearchItems([FromBody]string searchQuery)
        {
            IEnumerable<Item> items = new List<Item>();

            if(!string.IsNullOrEmpty(searchQuery))
            {
                items = _itemRepository.SearchItems(searchQuery);
            }
            return new JsonResult(items);
        }
    }
}
