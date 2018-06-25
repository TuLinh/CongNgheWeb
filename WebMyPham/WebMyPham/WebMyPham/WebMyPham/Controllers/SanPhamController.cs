using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;
using PagedList.Mvc;

namespace WebMyPham.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        WebMyPhamContent db = new WebMyPhamContent();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Category(string id)
        {

            try
            {
                {
                    //ViewBag.TieuDe = db.Categories.SingleOrDefault(p => p.Name != null).Name;
                    var model = db.SanPhams.Where(p => p.idloaisp == id).ToList();
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }

        }
        //Download source code tại Sharecode.vn
        public ActionResult Search(String SupplierId = "", string CategoryId = null, String Keywords = "")
        {
            if (SupplierId != "")
            {
                var model = db.SanPhams
                    .Where(p => p.idloaisp == SupplierId);
                return View(model);
            }
            else if (CategoryId != null)
            {
                var model = db.SanPhams
                    .Where(p => p.idloaisp == CategoryId);
                return View(model);
            }
            else if (Keywords != "")
            {
                var model = db.SanPhams
                    .Where(p => p.tensp.Contains(Keywords));
                return View(model);
            }
            return View(db.SanPhams);
        }

        public ActionResult Detail(int id, string SupplierID)
        {
            var model = db.SanPhams.Find(id);

            // Tăng số lần xem
            // model.Views++;
            db.SaveChanges();

            // Lấy cookie cũ tên views
            var views = Request.Cookies["views"];
            // Nếu chưa có cookie cũ -> tạo mới
            if (views == null)
            {
                views = new HttpCookie("views");
            }
            // Bổ sung mặt hàng đã xem vào cookie
            views.Values[id.ToString()] = id.ToString();
            // Đặt thời hạn tồn tại của cookie
            views.Expires = DateTime.Now.AddMonths(1);
            // Gửi cookie về client để lưu lại
            Response.Cookies.Add(views);

            // Lấy List<int> chứa mã hàng đã xem từ cookie
            var keys = views.Values
                .AllKeys.Select(k => int.Parse(k)).ToList();
            // Truy vấn háng đãn xem
            //ViewBag.Views = db.SanPhams
            //    .Where(p => keys.Contains(p.Id));
            return View(model);
        }
        public ActionResult Category(string Category_id, int? page)
        {
            if (Category_id != null)
            {
                int pagesize = 3;
                int pageNumber = (page ?? 1);
                var swap = new SanPham();
                var model = swap.ListAll().ToList().Where(p => p.idloaisp == Category_id);
                model = db.SanPhams.Where(p => p.idloaisp == Category_id).ToList().ToPagedList(pageNumber, pagesize);
                return View(model);
            }
            return View();
        }

    }
}