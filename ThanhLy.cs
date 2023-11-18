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
        public ThanhLy()
        {
            InitializeComponent();

            searchthanhly = new searchThanhLy();
            addthanhly = new addThanhLy();

            panelThanhLy.Controls.Add(searchthanhly);
            panelThanhLy.Controls.Add(addthanhly);

            searchthanhly.Show();
            addthanhly.Hide();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchthanhly.Hide();
            addthanhly.Show();
        }
    }
}
