using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySinhVien
{

    class SinhVien
    {
        SinhVienDAL dal = new SinhVienDAL();
        public DataTable DanhSachSinhVien()
        {
            return dal.DanhSachSinhVien();
        }
        public void InsertSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, string noiSinh, string danToc, string maLop)
        {
            dal.InsertSinhVien(maSV, hoTen, ngaySinh, gioiTinh, noiSinh, danToc, maLop);
        }
        public void DeleteSinhVien(string maSV)
        {
            dal.DeleteSinhVien(maSV);
        }
    }
}
