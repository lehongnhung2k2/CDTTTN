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
    public partial class editTTB : UserControl
    {
        private frmEditTTB frmeditttb;
        public editTTB()
        {
            InitializeComponent();

            frmeditttb = new frmEditTTB();

            panelEditTTB.Controls.Add(frmeditttb);

            frmeditttb.Hide();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            frmeditttb.Show();
        }
    }
}
