using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMyPham.Models;

namespace WebMyPham.Areas.Admin
{
    public class DonHangController : Controller
    {
        private WebMyPhamContent db = new WebMyPhamContent();
        // GET: Admin/DonHang
        public ActionResult Index()
        {
            return View(db.DonHangs.ToList());
        }
        //Get:Admin/DonHang/Details
        public ActionResult Details(int id)
        {
            if(id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donhang = db.DonHangs.Find(id);
            if(donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }
        //GET:Admin/DonHang/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST:Admin/DonHang/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="iddonhang,idKH,idsp,soluong,mota,trangthai,kieuthanhtoan,ngayxuat,tongtien,idnv")]DonHang donhang)
        {
            if(ModelState.IsValid)
            {
                db.DonHangs.Add(donhang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donhang);  
        }
        //GET:Admin/DonHang/Edit
        public ActionResult Edit(int id)
        {
            if(id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donhang = db.DonHangs.Find(id);
            if(donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }
        //POST:Admin/DonHang/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iddonhang,idKH,idsp,soluong,mota,trangthai,kieuthanhtoan,ngayxuat,tongtien,idnv")] DonHang donhang)
        {
            if(ModelState.IsValid)
            {
                db.Entry(donhang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donhang);
        }
        //GET:Admin/DonHang/Delete
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donhang = db.DonHangs.Find(id);
            if(donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DonHang donhang = db.DonHangs.Find(id);
            db.DonHangs.Remove(donhang);
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