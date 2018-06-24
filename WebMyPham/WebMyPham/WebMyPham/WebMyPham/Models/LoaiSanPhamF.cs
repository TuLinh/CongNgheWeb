using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMyPham.Models;

namespace WebMyPham.Models
{
    public class LoaiSanPhamF
    {
        private WebMyPhamContent context;

        public LoaiSanPhamF()
        {
            context = new WebMyPhamContent();
        }

        // Trả về danh muc
        public IQueryable<LoaiSanPham> LoaiSanPhams
        {
            get { return context.LoaiSanPhams; }
        }

        // Trả về một đối tượng danh mục, khi biết Khóa
        public LoaiSanPham FindEntity(string MaSP)
        {
            LoaiSanPham dbEntry = context.LoaiSanPhams.Find(MaSP);
            return dbEntry;
        }

        // Thêm một đối tượng
        public bool Insert(LoaiSanPham model)
        {
            LoaiSanPham dbEntry = context.LoaiSanPhams.Find(model.idloaisp);

            if (dbEntry != null)
            {
                return false;

            }
            context.LoaiSanPhams.Add(model);
            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(string MaSP)
        {
            LoaiSanPham dbEntry = context.LoaiSanPhams.Find(MaSP);
            if (dbEntry == null)
            {
                return false;
            }
            context.LoaiSanPhams.Remove(dbEntry);

            context.SaveChanges();
            return true;
        }
    }
}