using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;
using PagedList;
using PagedList.Mvc;



namespace WebMyPham.Controllers
{
    public class HomeController : Controller
    {
        WebMyPhamContent db = new WebMyPhamContent();
        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            
            var category = db.LoaiSanPhams.ToList();
            ViewData["LoaiSanPhams"] = category;
            var model = db.SanPhams.OrderBy(p => p.idloaisp).ToPagedList(pageNumber, pageSize);
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Category()
        {
            var Model = db.LoaiSanPhams;
            Session["LoaiSanPhams"] = Model;
            return PartialView("_Category", Model);
        }


    }
}