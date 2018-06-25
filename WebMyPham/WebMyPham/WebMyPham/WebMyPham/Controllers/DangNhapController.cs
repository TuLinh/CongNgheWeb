using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Controllers
{
    public class DangNhapController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: DangNhap
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string taikhoan = f["txtTaiKhoan"].ToString();
            string matkhau = f.Get("txtmatkhau").ToString();
            NguoiDung nguoidung = db.NguoiDungs.SingleOrDefault(n => n.username == taikhoan && n.password == matkhau);
            if(nguoidung != null)
            {
                ViewBag.ThongBao = "Chuc mung ban dang nhap thanh cong";
                Session["TaiKhoan"] = nguoidung;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}