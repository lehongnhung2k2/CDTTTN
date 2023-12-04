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
        private DieuChuyenTTB dieuchuyenttb;
        private exportTTB exportttb;
        public frmTrangThietBi()
        {
            InitializeComponent();
            searchttb = new searchTTB();
            addttb = new addTTB();
            editttb = new editTTB();
            dieuchuyenttb = new DieuChuyenTTB();
            exportttb = new exportTTB();

            panelTTB.Controls.Add(searchttb);
            panelTTB.Controls.Add(addttb);
            panelTTB.Controls.Add(editttb);
            panelTTB.Controls.Add(dieuchuyenttb);
            panelTTB.Controls.Add(exportttb);

            searchttb.Show();
            addttb.Hide();
            editttb.Hide();
            dieuchuyenttb.Hide();
            exportttb.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchttb.Hide();
            addttb.Show();
            editttb.Hide();
            dieuchuyenttb.Hide();
            exportttb.Hide();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchttb.Hide();
            addttb.Hide();
            editttb.Show();
            dieuchuyenttb.Hide();
            exportttb.Hide();
        }

        private void điềuChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchttb.Hide();
            addttb.Hide();
            editttb.Hide();
            dieuchuyenttb.Show();
            exportttb.Hide();
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchttb.Hide();
            addttb.Hide();
            editttb.Hide();
            dieuchuyenttb.Hide();
            exportttb.Show();
        }
    }
}
