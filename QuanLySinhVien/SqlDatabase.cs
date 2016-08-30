using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace QuanLySinhVien
{
    class SqlDatabase
    {
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Server =.; Database = QLSINHVIEN; Integrated security = true";
                return conn;
            }
        }
    }
}
