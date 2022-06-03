using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this._allOrders = allOrders;
            this._shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout1(Order order)
        {
            _shopCart.ShopCartItemsList = _shopCart.GetShopItems();
            if(_shopCart.ShopCartItemsList.Count == 0)
            {
                ModelState.AddModelError("", "У вас мають бути додані в кошик товари");
            }

            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Ви успішно замовили товар";
            return View();
        }
    }
}
