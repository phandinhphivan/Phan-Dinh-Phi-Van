using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    /// <summary>
    /// Interaction logic for QLDiem.xaml
    /// </summary>
    public partial class QLDiem : Window
    {
        SqlConnection conn = SqlDatabase.Connection;

        public QLDiem()
        {
            InitializeComponent();
            mauButton();
        }
        public void mauButton()
        {
            LinearGradientBrush br = new LinearGradientBrush();
            br.GradientStops.Add(new GradientStop(Colors.Bisque, 0.0));
            br.GradientStops.Add(new GradientStop(Colors.Blue, 1.0));
            btSearch.Background = br;
        }
        

        private void Diem_load(object sender, RoutedEventArgs e)
        {
            bindData();
        }
        private void bindData()
        {
            DataTable dt = new DataTable();
            string st = "SELECT * FROM diemHP";
            SqlDataAdapter da = new SqlDataAdapter(st, conn);
            da.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
        }


        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            string masv = txtMasv.Text;
            DataTable dt = new DataTable();
            string st = "SELECT * FROM diemHP WHERE maSV=" + "'" + masv + "'";
            SqlDataAdapter da = new SqlDataAdapter(st, conn);
            da.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
        }

        
    }
}
