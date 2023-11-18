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

namespace CDTTTN
{
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i, code;

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = tb_TaiKhoan.Text;
            string mk = tb_MatKhau.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from TaiKhoan "
                + " where " + "TenTK" + "=N'" + tk + "'"
                + " and " + " Matkhau" + "=N'" + mk + "'"
                + " and " + " MaPQ =N'admin'";
            cmd.Connection = conn;
            int kq = (int)cmd.ExecuteScalar();
            if (kq == 1)
            {
                frmTrangChu f = new frmTrangChu();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            //if (kq == 0)
            //{
            //    SqlCommand cd = new SqlCommand();
            //    cd.CommandType = CommandType.Text;
            //    cd.CommandText = "select count(*) from Tai_Khoan "
            //        + " where " + "TenTK" + "=N'" + tk + "'"
            //        + " and " + " Matkhau" + "=N'" + mk + "'"
            //        + " and " + " MaPQ =N'user'";
            //    cd.Connection = conn;
            //    int kq1 = (int)cd.ExecuteScalar();
            //    if (kq1 == 1)
            //    {
            //        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //frmTrangChu f = new frmTrangChu();
            //        frmTrangChu d = new frmTrangChu(txtTenDN.Text, txtMatKhau.Text);
            //        this.Hide();
            //        d.Show();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    frmTrangChuAdmin f = new frmTrangChuAdmin();
            //    this.Hide();
            //    f.Show();
            //}




        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            tb_MatKhau.UseSystemPasswordChar = false;

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
