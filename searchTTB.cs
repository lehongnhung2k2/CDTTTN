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
    public partial class searchTTB : UserControl
    {
        public searchTTB()
        {
            InitializeComponent();
        }

        private void btn_TimKiemTTB_Click(object sender, EventArgs e)
        {
            int dd = 0;
            string sql = "select * from TrangThietBi INNER JOIN TrangThai ON TrangThietBi.MaTT = TrangThai.MaTT where ";
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
            if (txt_TenTTB.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"TenTTB = N'{txt_TenTTB.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and TenTTB = N'{txt_TenTTB.Text}' ";
                }
                
            }
            if (txt_TrangThai.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"TrangThai = '{txt_TrangThai.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and TrangThai = '{txt_TrangThai.Text}' ";
                }
                
            }
            if (txt_MaNCC.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"MaNCC = '{txt_MaNCC.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and MaNCC = '{txt_MaNCC.Text}' ";
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
            if (txt_NgayNhap.Text != "")
            {
                DateTime result = DateTime.Parse(txt_NgayNhap.Text);
                if (dd == 0)
                {
                    sql += $"NgayNhap = '{result}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and NgayNhap = '{result}' ";
                }

            }
            grdTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);

        }

        private void searchTTB_Load(object sender, EventArgs e)
        {
            string sql = "select * from TrangThietBi";
            grdTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaTTB.Text = "";
            txt_TenTTB.Text = "";
            txt_TrangThai.Text = "";
            txt_NgayNhap.Text = "";
            txt_MaNCC.Text = "";
            txt_MaNV.Text = "";
        }
    }
}
