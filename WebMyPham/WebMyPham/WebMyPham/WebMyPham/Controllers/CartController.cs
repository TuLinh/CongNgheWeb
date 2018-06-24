using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiShop.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            var cart = GioHang.Cart;
            return View(cart.Items);
        }

        public ActionResult Add(string id)
        {
            var cart = GioHang.Cart;
            cart.Add(id);

            var info = new { cart.Count, cart.Total };
            return Json(info, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Remove(string id)
        {
            var cart = GioHang.Cart;
            cart.Remove(id);

            var info = new { cart.Count, cart.Total };
            return Json(info, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update(string id, int quantity)
        {
            var cart = GioHang.Cart;
            cart.Update(id, quantity);

            var p = cart.Items.Single(i => i.idsp == id);
            var info = new
            {
                cart.Count,
                cart.Total,
                Amount = p.giaban * p.soluong * (1 - p.giamgia)
            };
            return Json(info, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Clear()
        {
            var cart = GioHang.Cart;
            cart.Clear();
            return RedirectToAction("Index");
        }
    }
}