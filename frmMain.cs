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
        //SqlConnection conn = new SqlConnection();
        //SqlDataAdapter da = new SqlDataAdapter();
        //SqlCommand cmd = new SqlCommand();
        //DataTable dt = new DataTable();
        //string sql, constr;
        //int i, code;

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //string tk = tb_TaiKhoan.Text;
            //string mk = tb_MatKhau.Text;
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select count(*) from TaiKhoan "
            //    + " where " + "TenTK" + "=N'" + tk + "'"
            //    + " and " + " Matkhau" + "=N'" + mk + "'"
            //    + " and " + " MaPQ =N'admin'";
            //cmd.Connection = conn;
            //int kq = (int)cmd.ExecuteScalar();
            //if (kq == 1)
            //{
            //    frmTrangChu f = new frmTrangChu(tk);
            //    this.Hide();
            //    f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại");
            //}

            string tk = tb_TaiKhoan.Text;
            string mk = tb_MatKhau.Text;
           if (checkDangNhap(tk, mk))
            {
                frmTrangChu f = new frmTrangChu(tk);
                this.Hide();
                f.Show();
            }
           else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }



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
