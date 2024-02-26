using MusicStore.Models;

namespace MusicStore.Services
{
    public interface IShoppingCart
    {
        void AddToCart(Item item);
        int RemoveFromCart(Item item);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
