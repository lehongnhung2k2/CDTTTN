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
    public partial class frmTrangChu : Form
    {
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

        private void InitializeUserControls()
        {
            
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
           // label1.BringToFront();
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
