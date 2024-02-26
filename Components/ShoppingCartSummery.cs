using Microsoft.AspNetCore.Mvc;
using MusicStore.Services;
using MusicStore.ViewModels;

namespace MusicStore.Components
{
    public class ShoppingCartSummery : ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartSummery(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());
            
            return View(shoppingCartViewModel);
        }
    }
}
