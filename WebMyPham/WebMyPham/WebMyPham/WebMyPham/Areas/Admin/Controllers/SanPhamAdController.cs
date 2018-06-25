using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;
using System.Linq;

namespace WebMyPham.Areas.Admin.Controllers
{
    public class SanPhamAdController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: Admin/SanPhamAd
        public ActionResult Index()
        {
            var sanpham = db.SanPhams.Include(p => p.LoaiSanPham);
            return View(sanpham.ToList());
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
                    var path = Path.Combine(Server.MapPath("~/Images"), filename);
                   
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ThongBao = "Hình Ảnh đã tồn tại";
                    }
                    else   
                    {
                        Fileupload.SaveAs(path);    
                    }
                  //  sanpham.idsp = "";
                    sanpham.hinhanh = filename;
                    db.SanPhams.Add(sanpham);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
              
            }
            ViewBag.idsp = new SelectList(db.LoaiSanPhams, "idsp", "tensp", sanpham.idsp);
            return View(sanpham);
        }
        //get:Admin/SanPhamAd/Edit/5
        public ActionResult Edit(string id)
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
            ViewBag.idsp = new SelectList(db.LoaiSanPhams, "idsp", "tensp", sanpham.idsp);
            return View(sanpham);

        }
        //POST : Admin/SanPhamAd/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ([Bind(Include ="idsp,tensp,idloaisp,mota,giaban,soluong,giamgia,hinhanh,trangthai")] SanPham sanpham)
        {
            if(ModelState.IsValid)
            {
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idsp = new SelectList(db.LoaiSanPhams, "idsp", "tensp", sanpham.idsp);
            return View(sanpham);
        }
        //get: Admin/SanPhamAd/Delete/5
        public ActionResult Delete(string id)
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
        //Post : Admin/SanPhamAd/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed (string id)
        {
            SanPham sanpham = db.SanPhams.Find(id);
            db.SanPhams.Remove(sanpham);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}