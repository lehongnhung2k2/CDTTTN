﻿using System;
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
    public partial class frmrptDatPhong : Form
    {
        public frmrptDatPhong(rptDatPhong rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
