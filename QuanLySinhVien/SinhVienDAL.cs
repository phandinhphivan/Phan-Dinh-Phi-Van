using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySinhVien
{
    class SinhVienDAL
    {
        public DataTable DanhSachSinhVien()
        {
            SqlConnection conn = SqlDatabase.Connection;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
            conn.Close();

        }
        public void InsertSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, string noiSinh, string danToc, string maLop)
        {
            SqlConnection conn = SqlDatabase.Connection;
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [QLSINHVIEN].[dbo].SinhVien VALUES(N' " + maSV + " ', N' " + hoTen + " ', N' " + ngaySinh + " ', N' " + gioiTinh + " ', N' " + noiSinh + " ', N' " + danToc + " ', '"+ maLop +"')", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            conn.Close();
        }
        public void DeleteSinhVien(string maSV)
        {
             SqlConnection conn = SqlDatabase.Connection;
             conn.Open();
             SqlCommand cmd = new SqlCommand("DELETE FROM [QLSINHVIEN].[dbo].SinhVien WHERE maSV = '"+maSV+"'", conn);
             //SqlDataReader dr = cmd.ExecuteReader();
             cmd.ExecuteNonQuery();
             conn.Close();
        }
    }
}