using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Areas.Admin.Controllers
{
    public class TaiKhoanController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: Admin/TaiKhoan
        public ActionResult Index()
        {
            var model = db.NguoiDungs.Take(4);
            return View(model);
        }
    }
}