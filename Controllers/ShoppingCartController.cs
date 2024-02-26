using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Services;
using MusicStore.ViewModels;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly IShoppingCart _shoppingCart;
        private readonly ICurrencyService _currencyService;

        public ShoppingCartController(IItemRepository itemRepository, IShoppingCart shoppingCart, ICurrencyService currencyService)
        {
            _itemRepository = itemRepository;
            _shoppingCart = shoppingCart;
            _currencyService = currencyService;
        }

        public ViewResult Index()
        {
            (string selectedCurrency, decimal exchangeRate) = _currencyService.GetCurrencyInfo(HttpContext);

            ViewBag.SelectedCurrency = selectedCurrency;
            ViewBag.ExchangeRate = exchangeRate;

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart,
                _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }

        public IActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.AllItems.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem);
            }

            // Get the referring URL from the Referer header
            string referringUrl = Request.Headers["Referer"].ToString();

            // If the referring URL is empty or not from the same origin, redirect to a default page
            if (string.IsNullOrEmpty(referringUrl) || !Uri.IsWellFormedUriString(referringUrl, UriKind.Absolute))
            {
                return RedirectToAction("Index");
            }

            // Redirect back to the referring page
            return Redirect(referringUrl);
        }

        [HttpPost]
        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.AllItems.FirstOrDefault(p => p.ItemId == itemId);

            if(selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }
    }
}
