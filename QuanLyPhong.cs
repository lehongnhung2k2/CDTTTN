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
    public partial class QuanLyPhong : UserControl
    {
        private addPhong addphong;
        private editPhong editphong;
        private exportDatPhong exportdatphong;
        public QuanLyPhong()
        {
            InitializeComponent();

            addphong = new addPhong();
            editphong = new editPhong();
            exportdatphong = new exportDatPhong();

            panelPhong.Controls.Add(addphong);
            panelPhong.Controls.Add(editphong);
            panelPhong.Controls.Add(exportdatphong);

            addphong.Show();
            editphong.Hide();
            exportdatphong.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addphong.Show();
            editphong.Hide();
            exportdatphong.Hide();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addphong.Hide();
            editphong.Show();
            exportdatphong.Hide();
        }

        private void quảnLýĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addphong.Hide();
            editphong.Hide();
            exportdatphong.Show();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            if (classMain.MA_PQ == "manager")
            {
                thêmMớiToolStripMenuItem.Visible = false;
                chỉnhSửaToolStripMenuItem.Visible = false;
            }
        }
    }
}
