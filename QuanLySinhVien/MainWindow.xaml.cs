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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySinhVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SinhVien SV = new SinhVien();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_Thoat(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Load_SV(object sender, RoutedEventArgs e)
        {
            DataTable dt = SV.DanhSachSinhVien();
            dgvSinhVien.ItemsSource = dt.DefaultView;
            dgvSinhVien.SelectedValuePath = "maSV";
          
        }

        private void Click_Them(object sender, RoutedEventArgs e)
        {
            string maSV = txtmaSV.Text;
            //MessageBox.Show("ma sv: " + maSV);
            string hoTen = txthoTen.Text;
            string ngaySinh = timengaySinh.Text;

            string gioiTinh = txtgioiTinh.Text;

            string noiSinh = txtnoiSinh.Text;

            string danToc = txtdanToc.Text;

            string maLop = txtmaLop.Text;

            SV.InsertSinhVien(maSV, hoTen, ngaySinh, gioiTinh, noiSinh, danToc, maLop);
            DataView dv = (DataView)dgvSinhVien.ItemsSource;
            DataRowView row = dv.AddNew();
            row["maSV"] = maSV;
            row["hoTen"] = hoTen;
            row["ngaySinh"] = ngaySinh;
            row["gioiTinh"] = gioiTinh;
            row["noiSinh"] = noiSinh;
            row["danToc"] = danToc;
            row["maLop"] = maLop;
            row.EndEdit();

        }

        private void Click_Xoa(object sender, RoutedEventArgs e)
        {
            string maSV = dgvSinhVien.SelectedValue.ToString();
            MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa sinh viên mã " + maSV + " này không?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                SV.DeleteSinhVien(maSV);
                DataRowView dataview = (DataRowView)dgvSinhVien.SelectedItem;
                dataview.Delete();
            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            txtmaSV.IsEnabled = false;
            DataRowView data_select = (DataRowView)dgvSinhVien.SelectedItem;
            txtmaSV.Text = data_select["maSV"].ToString();
            txthoTen.Text = data_select["hoTen"].ToString();
            timengaySinh.Text = data_select["ngaySinh"].ToString();
            txtgioiTinh.Text = data_select["gioiTinh"].ToString();
            txtnoiSinh.Text = data_select["noiSinh"].ToString();
            txtdanToc.Text = data_select["danToc"].ToString();
            txtmaLop.Text = data_select["maLop"].ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string maSV = txtmaSV.Text;
            string hoTen = txthoTen.Text;
            string ngaySinh = timengaySinh.Text;
            string gioiTinh = txtgioiTinh.Text;
            string noiSinh = txtnoiSinh.Text;
            string danToc = txtdanToc.Text;
            string maLop = txtmaLop.Text;

            SV.UpdateSinhVien(maSV, hoTen, ngaySinh, gioiTinh, noiSinh, danToc, maLop);
            DataTable dt = SV.DanhSachSinhVien();
            dgvSinhVien.ItemsSource = dt.DefaultView;
        }
    }
}
