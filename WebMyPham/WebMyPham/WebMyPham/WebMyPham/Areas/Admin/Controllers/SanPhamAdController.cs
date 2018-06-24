using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Areas.Admin.Controllers
{
    public class SanPhamAdController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: Admin/SanPhamAd
        public ActionResult Index()
        {
            var sanpham = db.SanPhams.Include(p => p.LoaiSanPham);
            return View();
        }
        //Get:Admin/SanPhamad/Detail/5
        public ActionResult Details(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanpham = db.SanPhams.Find(id);
            if(sanpham == null)
            {
                return HttpNotFound();

            }
            return View(sanpham);
        }
        //Get;Admin/SanPhamAd/Create
        public ActionResult Create()
        {
            ViewBag.idsp = new SelectList(db.LoaiSanPhams, "idsp", "tensp");
            return View();

        }
        //Post:Admin/SanPhamAd/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create ([Bind(Include = "idsp,tensp,idloaisp,mota,giaban,soluong,giamgia,hinhanh,trangthai")] SanPham sanpham, HttpPostedFileBase Fileupload, HttpPostedFileBase Fileupload_2)
        {
            if(Fileupload == null)
            {
                ViewBag.ThongBao = "Yeu cau nhap lai hinh anh";
            }
            else
            {
                if(ModelState.IsValid)
                {
                    var filename = Path.GetFileName(Fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/images"), filename);
                    var filename_2 = Path.GetFileName(Fileupload_2.FileName);
                    var path_2 = Path.Combine(Server.MapPath("~/Content/images"), filename);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ThongBao = "Hình Ảnh đã tồn tại";
                    }
                    else
                     if (System.IO.File.Exists(path_2))
                    {
                        ViewBag.ThongBao = "Hình Ảnh đã tồn tại";
                    }

                    else
                    {
                        Fileupload.SaveAs(path);
                        Fileupload_2.SaveAs(path_2);
                    }
                    sanpham.idsp = "";
                    sanpham.hinhanh = filename;
                    db.SanPhams.Add(sanpham);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
              
            }
            ViewBag.idsp = new SelectList(db.LoaiSanPhams, "idsp", "tensp", sanpham.idsp);
            return View(sanpham);
        }

        
    }
}