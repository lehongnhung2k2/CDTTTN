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
        private editPhong editPhong;
        public QuanLyPhong()
        {
            InitializeComponent();

            addphong = new addPhong();
            editPhong = new editPhong();

            panelPhong.Controls.Add(addphong);
            panelPhong.Controls.Add(editPhong);

            addphong.Show();
            editPhong.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addphong.Show();
            editPhong.Hide();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addphong.Hide();
            editPhong.Show();
        }
    }
}
