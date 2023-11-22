﻿using System;
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
    public partial class frmTrangChu : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i, code;
        string taikhoan, TenNV;

        private TaiKhoanCuaToi taikhoancuatoi;
        private frmTrangThietBi trangthietbi;
        private DatPhong datphong;
        private KiemKe kiemke;
        private SuaChua suachua;
        private ThanhLy thanhly;
        private TrangChu trangchu;
        public frmTrangChu()
        {
            InitializeComponent();
            //InitializeUserControls();
            taikhoancuatoi = new TaiKhoanCuaToi();
            trangthietbi = new frmTrangThietBi();
            datphong = new DatPhong();
            kiemke = new KiemKe();
            suachua = new SuaChua();
            thanhly = new ThanhLy();
            trangchu = new TrangChu();

            panelControl.Controls.Add(taikhoancuatoi);
            panelControl.Controls.Add(trangthietbi);
            panelControl.Controls.Add(datphong);
            panelControl.Controls.Add(kiemke);
            panelControl.Controls.Add(suachua);
            panelControl.Controls.Add(thanhly);
            panelControl.Controls.Add(trangchu);

            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        public frmTrangChu(string tk) : this()
        {
            taikhoan = tk;

        }

        private void InitializeUserControls()
        {
            
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
        
            constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            //blTK.Text = username;
            sql = "select TenNV from TaiKhoan, NhanVien where TaiKhoan.MaNV = NhanVien.MaNV and TenTK='" + taikhoan + "'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dta = cmd.ExecuteReader();
            while (dta.Read() == true)
            {
                TenNV = dta["TenNV"].ToString();

            }
            lb_TenNV.Text = TenNV;
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            datphong.Hide();
            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            datphong.Hide();
            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            datphong.Show();
            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            datphong.Show();
            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            taikhoancuatoi.Show();
            trangthietbi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            taikhoancuatoi.Show();
            trangthietbi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void TTB_Click(object sender, EventArgs e)
        {
            trangthietbi.Show();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void img_TTB_Click(object sender, EventArgs e)
        {
            trangthietbi.Show();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_KiemKe_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Show();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void img_KiemKe_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Show();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void lb_SuaChua_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Show();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void img_SuaChua_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Show();
            thanhly.Hide();
            trangchu.Hide();
        }

        private void lb_ThanhLy_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Show();
            trangchu.Hide();
        }

        private void img_ThanhLy_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Show();
            trangchu.Hide();
        }
    }
}
