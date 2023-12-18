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
        private QuanLyPhong quanlyphong;
        private QuanLyTaiKhoan quanlytaikhoan;
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
            quanlyphong = new QuanLyPhong();
            quanlytaikhoan = new QuanLyTaiKhoan();

            panelControl.Controls.Add(taikhoancuatoi);
            panelControl.Controls.Add(trangthietbi);
            panelControl.Controls.Add(datphong);
            panelControl.Controls.Add(kiemke);
            panelControl.Controls.Add(suachua);
            panelControl.Controls.Add(thanhly);
            panelControl.Controls.Add(trangchu);
            panelControl.Controls.Add(quanlyphong);
            panelControl.Controls.Add(quanlytaikhoan);

            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Show();
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            pn.Controls.Add(pn_TrangChu);
            pn.Controls.Add(pn_DP);
            pn.Controls.Add(pn_QLP);
            pn.Controls.Add(pn_TTB);
            pn.Controls.Add(pn_KK);
            pn.Controls.Add(pn_SC);
            pn.Controls.Add(pn_TL);
            pn.Controls.Add(pn_QLTK);
            pn.Controls.Add(pn_TK);
            if (classMain.MA_PQ == "user")
            {
                pn.Controls.Remove(pn_QLP);
                pn.Controls.Remove(pn_TTB);
                pn.Controls.Remove(pn_KK);
                pn.Controls.Remove(pn_SC);
                pn.Controls.Remove(pn_TL);
                pn.Controls.Remove(pn_QLTK);
            }
            //Console.WriteLine(classMain.TENTAIKHOAN);

            constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            //blTK.Text = username;
            sql = "select * from TaiKhoan, NhanVien where TaiKhoan.MaNV = NhanVien.MaNV and TenTK='" + taikhoan + "'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dta = cmd.ExecuteReader();
            while (dta.Read() == true)
            {
                TenNV = dta["TenNV"].ToString();
                classMain.MANV = dta["MaNV"].ToString();

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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Show();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            datphong.Hide();
            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
            quanlyphong.Show();
            quanlytaikhoan.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            datphong.Hide();
            taikhoancuatoi.Hide();
            trangthietbi.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
            quanlyphong.Show();
            quanlytaikhoan.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
            quanlyphong.Hide();
            quanlytaikhoan.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            trangthietbi.Hide();
            taikhoancuatoi.Hide();
            datphong.Hide();
            kiemke.Hide();
            suachua.Hide();
            thanhly.Hide();
            trangchu.Hide();
            quanlyphong.Hide();
            quanlytaikhoan.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
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
            quanlyphong.Hide();
            quanlytaikhoan.Hide();
        }
    }
}
