using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;
using System.IO;
using System.Net;

namespace WebMyPham.Areas.Admin.Controllers
{
    public class ChiTietDonHangController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: Admin/ChiTietDonHang
        public ActionResult Index()
        {
            return View(db.ChiTietDonHangs.ToList());
        }
        //GET:Admin/ChiTietDonHang/Details
        public ActionResult Details(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang ctdonhang = db.ChiTietDonHangs.Find(id);
            if(ctdonhang == null)
            {
                return HttpNotFound();
            }
            return View(ctdonhang);
        }
        //GET:Admin/ChiTietDonHang/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Admin/ChiTietDonHang/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Bind(Include="")
    }
    

}