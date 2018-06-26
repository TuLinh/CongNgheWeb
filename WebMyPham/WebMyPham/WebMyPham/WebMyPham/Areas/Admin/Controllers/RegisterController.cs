using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Areas.Admin.Controllers
{
    public class RegisterController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NguoiDung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.NguoiDungs.Add(nguoidung);
                db.SaveChanges();
                return  Redirect("/Home/Index");
            }
            else
            {
                ViewBag.ThongBao = "Đăng ký không hợp lệ";
                return View();
            }

        }
    }
}