using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: Admin/TaiKhoan
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            string username = f["email"].ToString();
            string password = f.Get("password").ToString();
            var query = from NguoiDung in db.NguoiDungs
                        where NguoiDung.username == username
                        select NguoiDung;
            var Nguoidung = query.FirstOrDefault<NguoiDung>();
            string matkhau = Nguoidung.password.Trim();
            string quyen = Nguoidung.quyen.Trim();
            if (Nguoidung == null)
            {
                ViewBag.ThongBao = "Tài Khoản Không Tồn Tại.";
            }
            else
            if (Nguoidung != null)
            {
                if (matkhau != password)
                {
                    ViewBag.ThongBaomk = "Mật Khẩu không đúng.";
                    password = "";
                }
                else
                {
                    if (matkhau == password)
                    {
                        if (quyen == "admin")
                        {
                            return Redirect("/Admin/HomeAd/Index");
                        }
                        else
                        {
                            return Redirect("/Home/index");
                        }
                    }
                }
            }
            return View();

            //string username = f["email"].ToString();
            //string password = f.Get("password").ToString();
            //NguoiDung nd = db.NguoiDungs.SingleOrDefault(n => n.username == username && n.password == password);
            //if (nd != null)
            //{
            //    ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
            //    Session["TaiKhoan"] = nd;
            //    //ViewBag.TenTK = kh.HoTen;
            //    return RedirectToAction("Index", "Home");

            //}
            //ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
            //return View();
        }
    }
}