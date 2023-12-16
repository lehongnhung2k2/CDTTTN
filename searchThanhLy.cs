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
    public partial class searchThanhLy : UserControl
    {
        public searchThanhLy()
        {
            InitializeComponent();
        }

        private void searchThanhLy_Load(object sender, EventArgs e)
        {
            string sql = "select * from ThanhLy";
            grdThanhLy.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_MaTL.Text = "";
            txt_MaTTB.Text = "";
            txt_NgayTL.Text = "";
            txt_NguoiMua.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int dd = 0;
            string sql = "SELECT * FROM ThanhLy where ";
            if (txt_NguoiMua.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"NguoiMua = '{txt_NguoiMua.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and NguoiMua = '{txt_NguoiMua.Text}' ";
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
            if (txt_MaTL.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"MaTL = '{txt_MaTL.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and MaTL = '{txt_MaTL.Text}' ";
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
            if (txt_NgayTL.Text != "")
            {
                DateTime kq = DateTime.Parse(txt_NgayTL.Text);
                if (dd == 0)
                {
                    sql += $"NgayTL = '{kq}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and NgayTL = '{kq}' ";
                }

            }
            grdThanhLy.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
