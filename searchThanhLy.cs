﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CDTTTN
{
    public partial class searchThanhLy : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public searchThanhLy()
        {
            InitializeComponent();
        }

        private void searchThanhLy_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select * from ThanhLy";
            //truyen da cau lenh sql va ket noi toi conn
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdThanhLy.DataSource = dt;
        }
    }
}
