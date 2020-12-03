using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveInCircle.UI.MVC.Helper;
using LiveInCircle.UI.MVC.Models.Cart;
using Microsoft.AspNetCore.Mvc;

namespace LiveInCircle.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View(HttpContext.Session.Get<MyCart>("cart"));
        }
        [HttpPost]
        public IActionResult AddToCart([FromBody]CartVM cart)
        {
            MyCart sepet = HttpContext.Session.Get<MyCart>("cart");
            CartItem cartItem = new CartItem();
            cartItem.ID = cart.ID;
            cartItem.Name = cart.Name;
            cartItem.Price = cart.Price;
            cartItem.Amount = 1;
            sepet.AddCart(cartItem);
            HttpContext.Session.Set<MyCart>("cart", sepet);
            return PartialView("_cartButton",sepet.TotalAmount);

        }

        public IActionResult GetCartButton()
        {
            MyCart cart = HttpContext.Session.Get<MyCart>("cart");
            return PartialView("_cartButton", cart.TotalAmount);
        }
        
        public IActionResult UpdateToCart(short amount,int id)
        {
            MyCart guncellenecekSepet= HttpContext.Session.Get<MyCart>("cart");
            guncellenecekSepet.Update(id, amount);
            HttpContext.Session.Set<MyCart>("cart", guncellenecekSepet);
            return PartialView("_tableList", guncellenecekSepet);
        }

        public IActionResult DeleteToCart(int id)
        {
            MyCart silinecekSepet = HttpContext.Session.Get<MyCart>("cart");
            silinecekSepet.Delete(id);
            HttpContext.Session.Set<MyCart>("cart", silinecekSepet);
            return PartialView("_tableList", silinecekSepet);
        }
    }
}
