
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //lớp ánh xạ bảng tài khoản người dùng
    public class TaiKhoan
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public int MaCV { get; set; }
    }
}