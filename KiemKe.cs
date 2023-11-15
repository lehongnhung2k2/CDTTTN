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
    public partial class KiemKe : UserControl
    {
        private searchKiemKe searchkiemke;
        private addKiemKe addkiemke;
        public KiemKe()
        {
            InitializeComponent();

            searchkiemke = new searchKiemKe();
            addkiemke = new addKiemKe();

            panelKiemKe.Controls.Add(searchkiemke);
            panelKiemKe.Controls.Add(addkiemke);

            searchkiemke.Show();
            addkiemke.Hide();
        }

        private void theeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchkiemke.Hide();
            addkiemke.Show();
        }
    }
}
