using CDTTTN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDTTTN
{
    public partial class TaiKhoanCuaToi : UserControl
    {
        string TenPB, TenNV, DiaChi, SDT, TenTK, Email;
        public TaiKhoanCuaToi()
        {
            InitializeComponent();
        }

        private void TaiKhoanCuaToi_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";

            // SQL query to retrieve the required information
            string query = "SELECT PhongBan.TenPB, NhanVien.TenNV, NhanVien.DiaChi, NhanVien.SDT, TaiKhoan.TenTK " +
                           "FROM PhongBan " +
                           "JOIN NhanVien ON PhongBan.MaPB = NhanVien.MaPB " +
                           $"JOIN TaiKhoan ON NhanVien.MaNV = TaiKhoan.MaNV where TaiKhoan.TenTK = '{classMain.TENTAIKHOAN}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if the reader has any rows
                        if (reader.HasRows)
                        {
                            // Loop through the rows and print the values
                            while (reader.Read())
                            {
                                TenPB = reader["TenPB"].ToString();
                                TenNV = reader["TenNV"].ToString();
                                DiaChi = reader["DiaChi"].ToString();
                                SDT = reader["SDT"].ToString();
                                TenTK = reader["TenTK"].ToString();
                                //Email = reader["Email"].ToString();

                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            txt_TenTK.Text = TenTK;
            txt_TenNV.Text = TenNV;
            txt_HoTen.Text = TenNV;
            txt_PhongBan.Text = TenPB;
            txt_Email.Text = "";
            txt_SDT.Text = SDT;
            txt_DiaChi.Text = DiaChi;
            txt_NgaySinh.Text = "";
            txt_GioiTinh.Text = "";
        }

        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            if (btn_SuaThongTin.Text == "Sửa thông tin")
            {
                btn_SuaThongTin.Text = "Lưu";
                txt_HoTen.ReadOnly = false;
                txt_GioiTinh.ReadOnly = false;
                txt_NgaySinh.ReadOnly = false;
                txt_Email.ReadOnly = false;
                txt_SDT.ReadOnly = false;
                txt_DiaChi.ReadOnly = false;
            }    
            else
            {
                btn_SuaThongTin.Text = "Sửa thông tin";
                txt_HoTen.ReadOnly = true;
                txt_GioiTinh.ReadOnly = true;
                txt_NgaySinh.ReadOnly = true;
                txt_Email.ReadOnly = true;
                txt_SDT.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
            }    
            
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.Show();
        }
    }
}
