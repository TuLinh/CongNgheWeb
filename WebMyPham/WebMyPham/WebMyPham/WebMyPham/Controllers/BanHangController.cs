using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Controllers
{
    public class BanHangController : Controller
    {
        WebMyPhamContent db = new WebMyPhamContent();
        //
        // GET: /Order/
        public ActionResult Checkout()
        {
            var model = new DonHang();
           // model.idKH = KhachHang.Identity.Name;
            model.ngayxuat = DateTime.Now.Date;
            //model.tongtien = GioHang.Total();

            return View(model);
        }

        //public ActionResult Purchase(DonHang model)
        //{
        //    db.DonHangs.Add(model);

        //    var cart = GioHang.Cart;
        //    foreach (var p in cart.Items)
        //    {
        //        var d = new SanPham
        //        {

        //            idsp = p.Id,
        //            soluong = p.soluong;


        //    };

        //    db.SanPhams.Add(d);
        //}
        //db.SaveChanges();

            // Thanh toán trực tuyến
            //var api = new WebApiClient<AccountInfo>();
            //var data = new AccountInfo { 
            //    Id=Request["BankAccount"],
            //    Balance = cart.Total
            //};
        //    //api.Put("api/Bank/nn", data);
        //    return RedirectToAction("Detail", new { id = model.Id });
        //}

        //public ActionResult Detail(int id)
        //{
        //    var order = db.DonHangs.Find(id);
        //    return View(order);
        //}

        //public ActionResult List()
        //{
        //    var orders = db.DonHangs
        //        .Where(o => o.idKH == User.Identity.);
        //    return View(orders);
        //}
    }
}