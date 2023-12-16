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
    public partial class ThanhLy : UserControl
    {
        private searchThanhLy searchthanhly;
        private addThanhLy addthanhly;
        private exportThanhLy exportthanhly;
        public ThanhLy()
        {
            InitializeComponent();

            searchthanhly = new searchThanhLy();
            addthanhly = new addThanhLy();
            exportthanhly = new exportThanhLy();

            panelThanhLy.Controls.Add(searchthanhly);
            panelThanhLy.Controls.Add(addthanhly);
            panelThanhLy.Controls.Add(exportthanhly);

            searchthanhly.Show();
            addthanhly.Hide();
            exportthanhly.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchthanhly.Hide();
            addthanhly.Show();
            exportthanhly.Hide();
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchthanhly.Hide();
            addthanhly.Hide();
            exportthanhly.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchthanhly.Show();
            addthanhly.Hide();
            exportthanhly.Hide();
        }
    }
}
