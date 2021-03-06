using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    //lớp TaiKhoanBl có các phương thức xử lý bảng Foood
    public class TaiKhoanBL
    {
        //Đối tượng CategoryDA từ DataAccess
        TaiKhoanDA tkDA = new TaiKhoanDA();
        //Phương thức lấy hết dữ liệu
        public List<TaiKhoan> GetAll()
        {
            return tkDA.GetAll();
        }
        // Phương thức lấy về đối tượng Food theo khoá chính
        public TaiKhoan GetByName(string name)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var item in list)
            {
                if (item.TenTaiKhoan==name)
                {
                    return item;
                }
            }
            return null;
        }
        public List<TaiKhoan> Find(string key)
        {
            List<TaiKhoan> list=GetAll();
            List<TaiKhoan> result=new List<TaiKhoan>();

            foreach (var item int list){
                if (item.TenTaiKhoan.Contain(key)
                ||item.MatKhau.Contain(key)
                ||item.HoTen.Contain(key)
                ||item.NgayTao.Contain(key)
                ||item.Email.Contain(key)
                ||item.SoDienThoai.Contain(key)
                result.Add(item);
                )
            }
            return result;
        }

        // phương thức thêm dữ liệu
        public int Insert(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 0);
        }
        // phương thức xóa dữ liệu
        public int Delete(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 1);
        }
        // phương thức sửa dữ liệu
        public int Update(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 2);
        }

        //kiểm tra đăng nhập

        //phân quyền





    }
}