using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebMyPham.Models;

namespace WebMyPham.Models
{
    public class NguoiDungF
    {
        WebMyPhamContent db = new WebMyPhamContent();
        public NguoiDung GetById(string userName)
        {
            return db.NguoiDungs.SingleOrDefault(x => x.username == userName);
        }


        public bool CheckUserName(string userName)
        {
            return db.NguoiDungs.Count(x => x.username == userName) > 0;
        }
    }
}