using CDTTTN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDTTTN
{
    public partial class QuanLyTaiKhoan : UserControl
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            
        }

        public void NapCT()
        {
            int i = grd_TaiKhoan.CurrentRow.Index;
            txt_TenTK.Text = grd_TaiKhoan.Rows[i].Cells["TenTK"].Value.ToString();
            txt_MatKhau.Text = grd_TaiKhoan.Rows[i].Cells["MatKhau"].Value.ToString();
            txt_MaPQ.Text = grd_TaiKhoan.Rows[i].Cells["MaPQ"].Value.ToString();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT NV.MaNV, NV.TenNV, TK.TenTK, TK.MatKhau, TK.MaPQ
            FROM NhanVien NV
            INNER JOIN TaiKhoan TK ON NV.MaNV = TK.MaNV";

            grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            NapCT();
        }

        private void btn_TimKiemTTB_Click(object sender, EventArgs e)
        {
            if (txt_TenNV.Text == "")
            {
                string sql = @"SELECT NV.MaNV, NV.TenNV, TK.TenTK, TK.MatKhau, TK.MaPQ
                FROM NhanVien NV
                INNER JOIN TaiKhoan TK ON NV.MaNV = TK.MaNV";
                grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
            else
            {
                string sql = $"SELECT NV.MaNV, NV.TenNV, TK.TenTK, TK.MatKhau, TK.MaPQ FROM NhanVien NV INNER JOIN TaiKhoan TK ON NV.MaNV = TK.MaNV where NV.TenNV = N'{txt_TenNV.Text}'";
                grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
        }

        private void grd_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa tài khoản này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                //string TenTK = txt_TenTK.Text;
                //string MatKhau = txt_MatKhau.Text;
                //string MaPQ = txt_MaPQ.Text;
                
                string sql = $"UPDATE TaiKhoan SET MatKhau = '{txt_MatKhau.Text}', MaPQ = '{txt_MaPQ.Text}'";
                grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);

                sql = @"SELECT NV.MaNV, NV.TenNV, TK.TenTK, TK.MatKhau, TK.MaPQ
                FROM NhanVien NV
                INNER JOIN TaiKhoan TK ON NV.MaNV = TK.MaNV";

                grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {

                string sql = $"DELETE FROM TaiKhoan WHERE TenTK = '{txt_TenTK.Text}'";
                grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);

                sql = @"SELECT NV.MaNV, NV.TenNV, TK.TenTK, TK.MatKhau, TK.MaPQ
                FROM NhanVien NV
                INNER JOIN TaiKhoan TK ON NV.MaNV = TK.MaNV";

                grd_TaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
        }
    }
}
