using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CDTTTN.DAO;

namespace CDTTTN
{
    public partial class searchSuaChua : UserControl
    {
        public searchSuaChua()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_GiaSC.Text = "";
            txt_MaNV.Text = "";
            txt_MaSC.Text = "";
            txt_MaTTB.Text = "";
            txt_NgaySC.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int dd = 0;
                string sql = "SELECT * FROM SuaChua where ";
                if (txt_GiaSC.Text != "")
                {
                    float kq = float.Parse(txt_GiaSC.Text);
                    if (dd == 0)
                    {
                        sql += $"GiaSC = {kq} ";
                        ++dd;
                    }
                    else
                    {
                        sql += $"and GiaSC = {kq} ";
                    }
                }
                if (txt_MaNV.Text != "")
                {
                    if (dd == 0)
                    {
                        sql += $"MaNV = '{txt_MaNV.Text}' ";
                        ++dd;
                    }
                    else
                    {
                        sql += $"and MaNV = '{txt_MaNV.Text}' ";
                    }
                }
                if (txt_MaSC.Text != "")
                {
                    if (dd == 0)
                    {
                        sql += $"MaSC = '{txt_MaSC.Text}' ";
                        ++dd;
                    }
                    else
                    {
                        sql += $"and MaSC = '{txt_MaSC.Text}' ";
                    }
                }
                if (txt_MaTTB.Text != "")
                {
                    if (dd == 0)
                    {
                        sql += $"MaTTB = '{txt_MaTTB.Text}' ";
                        ++dd;
                    }
                    else
                    {
                        sql += $"and MaTTB = '{txt_MaTTB.Text}' ";
                    }
                }
                if (txt_NgaySC.Text != "")
                {
                    DateTime kq = DateTime.Parse(txt_NgaySC.Text);
                    if (dd == 0)
                    {
                        sql += $"NgaySC = '{kq}' ";
                        ++dd;
                    }
                    else
                    {
                        sql += $"and NgaySC = '{kq}' ";
                    }

                }
                grdSuaChua.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
            
        }

        private void searchSuaChua_Load(object sender, EventArgs e)
        {
            string sql = "select * from SuaChua";
            grdSuaChua.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
