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
    public partial class frmDoiMatKhau : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_MK_cu.UseSystemPasswordChar = false;
            txt_MK_moi.UseSystemPasswordChar = false;
            txt_MK_moi_1.UseSystemPasswordChar = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_MK_cu.UseSystemPasswordChar = true;
                txt_MK_moi.UseSystemPasswordChar = true;
                txt_MK_moi_1.UseSystemPasswordChar = true;
            }
            else
            {
                txt_MK_cu.UseSystemPasswordChar = false;
                txt_MK_moi.UseSystemPasswordChar = false;
                txt_MK_moi_1.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MK_cu = txt_MK_cu.Text;
            string MK_moi = txt_MK_moi.Text;
            string MK_moi_1 = txt_MK_moi_1.Text;
            string MK="";

            constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            //blTK.Text = username;
            sql = $"select * from TaiKhoan where TenTK='{classMain.TENTAIKHOAN}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dta = cmd.ExecuteReader();
            while (dta.Read() == true)
            {
                MK = dta["MatKhau"].ToString();

            }
            conn.Close();

            if (MK_cu == MK)
            {
                if (MK_moi == MK_moi_1)
                {
                    string sql1 = $"update TaiKhoan set MatKhau = '{MK_moi}' where TenTK='{classMain.TENTAIKHOAN}'";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu");
            }
        }
    }
}
