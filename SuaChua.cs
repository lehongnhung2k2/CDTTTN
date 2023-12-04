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
    public partial class SuaChua : UserControl
    {
        private searchSuaChua searchsuachua;
        private addSuaChua addsuachua;
        private exportSuaChua exportsuachua;
        public SuaChua()
        {
            InitializeComponent();

            searchsuachua = new searchSuaChua();
            addsuachua = new addSuaChua();
            exportsuachua = new exportSuaChua();

            panelSuaChua.Controls.Add(searchsuachua);
            panelSuaChua.Controls.Add(addsuachua);
            panelSuaChua.Controls.Add(exportsuachua);

            searchsuachua.Show();
            addsuachua.Hide();
            exportsuachua.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchsuachua.Hide();
            addsuachua.Show();
            exportsuachua.Hide();
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchsuachua.Hide();
            addsuachua.Hide();
            exportsuachua.Show();
        }
    }
}
