using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;
using PagedList;

namespace WebMyPham.Controllers
{
    public class MaiThiLinhController : Controller
    {
        // GET: MaiThiLinh
        WebMyPhamContent db = new WebMyPhamContent();
        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);

            var category = db.SanPhams.ToList();
            ViewData["SanPham"] = category;
            var model = db.SanPhams.OrderBy(p => p.idloaisp).ToPagedList(pageNumber, pageSize);
            return View(model);
        }
    }
}