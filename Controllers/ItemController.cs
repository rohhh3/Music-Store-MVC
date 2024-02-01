using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Services;
using MusicStore.ViewModels;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace MusicStore.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICurrencyService _currencyService;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository , ICurrencyService currencyService)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
            _currencyService = currencyService;
        }

        public ViewResult List(string category)
        {
            (string selectedCurrency, decimal exchangeRate) = _currencyService.GetCurrencyInfo(HttpContext);

            ViewBag.SelectedCurrency = selectedCurrency;
            ViewBag.ExchangeRate = exchangeRate;

            IEnumerable<Item> items;
            string? currentCategory;
            string? categoryImageUrl;
            string? categoryName;
            
            if(string.IsNullOrEmpty(category))
            {
                items = _itemRepository.AllItems.OrderBy(i => i.ItemId);
                currentCategory = "All items";
                categoryImageUrl = null;
                categoryName = null;
            }

            else
            {
                items = _itemRepository.AllItems.Where(i => i.Category.CategoryName == category)
                    .OrderBy(i => i.ItemId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
                categoryImageUrl = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.ImageUrl;
                categoryName = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new ItemListViewModel(items, currentCategory, categoryImageUrl, categoryName));
            
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);

            (string selectedCurrency, decimal exchangeRate) = _currencyService.GetCurrencyInfo(HttpContext);

            ViewBag.SelectedCurrency = selectedCurrency;
            ViewBag.ExchangeRate = exchangeRate;

            if (item == null)
                return NotFound();
            return View(item);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
