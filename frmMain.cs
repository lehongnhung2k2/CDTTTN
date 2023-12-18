using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CDTTTN.DAO;

namespace CDTTTN
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = tb_TaiKhoan.Text;
                string mk = tb_MatKhau.Text;
                string MaPQ = "";

                string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = $"select * from TaiKhoan where TenTK = '{tk}' and MatKhau = '{mk}'";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MaPQ = reader["MaPQ"].ToString();
                                classMain.MA_PQ = MaPQ;
                                if (MaPQ != "")
                                {

                                    frmTrangChu f = new frmTrangChu(tk);
                                    this.Hide();
                                    f.Show();
                                }

                            }
                        }
                        if (MaPQ == "")
                        {
                            MessageBox.Show("Đăng nhập không thành công");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
            
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Không thành công");
            //}


            // string sql = $"select count(*) from TaiKhoan where TenTK = '{tk}' and MatKhau = '{mk}' and MaPQ = 'admin'";
            // DataTable result = DataProvider.Instance.ExcuteQuery(sql);
            // Console.WriteLine(result.Rows.Count);


            // if (checkDangNhap(tk, mk))
            // {
            //     frmTrangChu f = new frmTrangChu(tk);
            //     this.Hide();
            //     f.Show();
            // }
            //else
            // {
            //     MessageBox.Show("Đăng nhập không thành công");
            // }



        }

        bool checkDangNhap(string tk, string mk)
        {
            return TaiKhoanDAO.Instance.checkDangNhap(tk, mk);
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.keychar == (char)keys.enter)
            //{
            //    btndangnhap.performclick(); // tự động kích hoạt sự kiện click của button
            //}
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
              
            //    btnDangNhap.PerformClick(); // Tự động kích hoạt sự kiện Click của Button
            //}
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            //conn.ConnectionString = constr;
            //conn.Open();

            tb_MatKhau.UseSystemPasswordChar = false;
            classMain.TENTAIKHOAN = tb_TaiKhoan.Text;
            //Console.WriteLine(classMain.TENTAIKHOAN);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_MatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                tb_MatKhau.UseSystemPasswordChar = false;
            }
        }
        
    }
}
