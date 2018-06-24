using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMyPham.Models;

namespace WebMyPham.Models
{
    public class SANPHAMF
    {
        private WebMyPhamContent context;
        public SANPHAMF()
        {
            context = new WebMyPhamContent();
        }
        //Trả về danh mục
        public IQueryable<SanPham> DSSanPham
        {
            get { return context.SanPhams; }
        }
        public List<SanPham> GetList()
        {
            return context.SanPhams.ToList();
        }
        //Trả về một đối tượng danh mục,khi biết Khóa
        public SanPham FinEntity(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            return dbEntry;
        }
        //Thêm một đối tượng
        public bool Insert(SanPham model)
        {
            SanPham dbEntry = context.SanPhams.Find(model.idsp);
            if(dbEntry !=null)
            {
                return false;
            }
            context.SanPhams.Add(model);
            context.SaveChanges();
            return true;
        }
       // Sửa một đối tượng
        public bool Update(SanPham model)
        {
            SanPham dbEntry = context.SanPhams.Find(model.idsp);
            if (dbEntry == null)
            { return false; }
        
            dbEntry.idsp = model.idsp;
            dbEntry.mota = model.mota;
            dbEntry.hinhanh = model.hinhanh;
            dbEntry.giaban = model.giaban;
            dbEntry.giamgia = model.giamgia;
            dbEntry.trangthai = model.trangthai;
            //Sửa các trường hợp khác cũng như vậy
            context.SaveChanges();
            return true;


        }
        //Xóa một đối tượng
        public bool Delete(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            if(dbEntry== null)
            {
                return false;
            }
            context.SanPhams.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}