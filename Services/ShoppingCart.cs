﻿using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Services
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()
                ?.HttpContext?.Session;

            AppDbContext context = services.GetService<AppDbContext>()
                ?? throw new Exception("Error initialzing database");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Item item)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                               s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Item = item,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }

            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Item item)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                               s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            int localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }

                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _appDbContext.ShoppingCartItems.Where(
                               c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Item)
                .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(
                                              c => c.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(
                                              c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Item.Price * c.Amount).Sum();
            return total;
        }
    }
}
