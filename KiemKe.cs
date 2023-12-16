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
        private exportKiemKe exportkiemke;
        public KiemKe()
        {
            InitializeComponent();

            searchkiemke = new searchKiemKe();
            addkiemke = new addKiemKe();
            exportkiemke = new exportKiemKe();

            panelKiemKe.Controls.Add(searchkiemke);
            panelKiemKe.Controls.Add(addkiemke);
            panelKiemKe.Controls.Add(exportkiemke);

            searchkiemke.Show();
            addkiemke.Hide();
            exportkiemke.Hide();
        }

        private void theeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchkiemke.Hide();
            addkiemke.Show();
            exportkiemke.Hide();
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchkiemke.Hide();
            addkiemke.Hide();
            exportkiemke.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchkiemke.Show();
            addkiemke.Hide();
            exportkiemke.Hide();
        }
    }
}
