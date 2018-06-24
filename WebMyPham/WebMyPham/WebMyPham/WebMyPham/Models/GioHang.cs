using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMyPham.Models;

public class GioHang
{
    // Lấy giỏ hàng từ Session
    public static GioHang Cart
    {
        get
        {
            var cart = HttpContext.Current.Session["Cart"] as GioHang;
            // Nếu chưa có giỏ hàng trong session -> tạo mới và lưu vào session
            if (cart == null)
            {
                cart = new GioHang();
                HttpContext.Current.Session["Cart"] = cart;
            }
            return cart;
        }
    }
    //Download source code tại Sharecode.vn
    // Chứa các mặt hàng đã chọn
    public List<SanPham> Items = new List<SanPham>();

    public void Add(string id)
    {
        try // tìm thấy trong giỏ -> tăng số lượng lên 1
        {
            var item = Items.Single(i => i.idsp == id);
            item.soluong++;
        }
        catch // chưa có trong giỏ -> truy vấn CSDL và bỏ vào giỏ
        {
            var db = new WebMyPhamContent();
            var item = db.SanPhams.Find(id);
            item.soluong = 1;
            Items.Add(item);
        }
    }

    public void Remove(string id)
    {
        var item = Items.Single(i => i.idsp == id);
        Items.Remove(item);
    }

    public void Update(string id, int newQuantity)
    {
        var item = Items.Single(i => i.idsp == id);
        item.soluong = newQuantity;
    }

    public void Clear()
    {
        Items.Clear();
    }

    public int Count
    {
        get
        {
            return Items.Count;
        }
    }

    public double Total
    {
        get
        {
            return Items.Sum(p =>
                p.giaban * p.soluong * (1 - p.giamgia));
        }
    }
}