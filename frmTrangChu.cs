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
        public frmTrangChu()
        {
            InitializeComponent();
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
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DatPhong userControl = new DatPhong();
            panelControl.Controls.Add(userControl);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DatPhong userControl = new DatPhong();
            panelControl.Controls.Add(userControl);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            TaiKhoanCuaToi userControl = new TaiKhoanCuaToi();
            panelControl.Controls.Add(userControl);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TaiKhoanCuaToi userControl = new TaiKhoanCuaToi();
            panelControl.Controls.Add(userControl);
        }
    }
}
