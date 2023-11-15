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
    public partial class frmTrangThietBi : UserControl
    {
        private searchTTB searchttb;
        private addTTB addttb;
        private editTTB editttb;
        public frmTrangThietBi()
        {
            InitializeComponent();
            searchttb = new searchTTB();
            addttb = new addTTB();
            editttb = new editTTB();

            panelTTB.Controls.Add(searchttb);
            panelTTB.Controls.Add(addttb);
            panelTTB.Controls.Add(editttb);

            searchttb.Show();
            addttb.Hide();
            editttb.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchttb.Hide();
            addttb.Show();
            editttb.Hide();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchttb.Hide();
            addttb.Hide();
            editttb.Show();
        }
    }
}
