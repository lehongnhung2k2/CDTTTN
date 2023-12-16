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
    public partial class searchKiemKe : UserControl
    {
        public searchKiemKe()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int dd = 0;
            string sql = "SELECT * FROM KiemKe INNER JOIN ChiTietKiemKe ON KiemKe.MaKK = ChiTietKiemKe.MaKK where ";
            if (txt_MaKK.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"KiemKe.MaKK = '{txt_MaKK.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and KiemKe.MaKK = '{txt_MaKK.Text}' ";
                }
            }
            if (txt_MaNV.Text != "")
            {
                if (dd == 0)
                {
                    sql += $"KiemKe.MaNV = '{txt_MaNV.Text}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and KiemKe.MaNV = '{txt_MaNV.Text}' ";
                }
            }
            if (txt_NgayKK.Text != "")
            {
                DateTime result = DateTime.Parse(txt_NgayKK.Text);
                if (dd == 0)
                {
                    sql += $"KiemKe.NgayKK = '{result}' ";
                    ++dd;
                }
                else
                {
                    sql += $"and KiemKe.NgayKK = '{result}' ";
                }

            }
            grdKiemKe.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void searchKiemKe_Load(object sender, EventArgs e)
        {
            string sql = "SELECT KiemKe.MaKK, KiemKe.NgayKK, KiemKe.MaNV, ChiTietKiemKe.GhiChu, ChiTietKiemKe.MaTT, ChiTietKiemKe.MaTTB FROM KiemKe INNER JOIN ChiTietKiemKe ON KiemKe.MaKK = ChiTietKiemKe.MaKK";
            grdKiemKe.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MaKK.Text = "";
            txt_MaNV.Text = "";
            txt_NgayKK.Text = "";
        }
    }
}
