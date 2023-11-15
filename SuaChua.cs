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
        public SuaChua()
        {
            InitializeComponent();

            searchsuachua = new searchSuaChua();
            addsuachua = new addSuaChua();

            panelSuaChua.Controls.Add(searchsuachua);
            panelSuaChua.Controls.Add(addsuachua);

            searchsuachua.Show();
            addsuachua.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchsuachua.Hide();
            addsuachua.Show();
        }
    }
}
