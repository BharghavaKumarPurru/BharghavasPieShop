﻿using BharghavasPieShop.Models;
using BharghavasPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BharghavasPieShop.Components
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;
        public ShoppingCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            //var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, 
                _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }



    }
}
