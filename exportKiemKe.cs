using CDTTTN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDTTTN
{
    public partial class exportKiemKe : UserControl
    {
        string TenTruong;
        public exportKiemKe()
        {
            InitializeComponent();
        }

        private void exportKiemKe_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT KK.MaKK, KK.NgayKK, KK.MaNV, CTKK.MaTTB, TTB.TenTTB, CTKK.MaTT, CTKK.GhiChu
            FROM KiemKe KK
            INNER JOIN ChiTietKiemKe CTKK ON KK.MaKK = CTKK.MaKK
            INNER JOIN TrangThietBi TTB ON CTKK.MaTTB = TTB.MaTTB";
            grd_exportKiemKe.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void cb_TenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (cb_TenTruong.Text == "TenTTB")
            {
                TenTruong = "TrangThietBi.TenTTB";
                sql = "select distinct TenTTB from TrangThietBi";
            }
            else if (cb_TenTruong.Text == "NgayKK")
            {
                TenTruong = "KiemKe.NgayKK";
                sql = "select distinct NgayKK from KiemKe";
            }
            else
            {
                TenTruong = "ChiTietKiemKe.MaKK";
                sql = "select distinct MaKK from ChiTietKiemKe";
            }


            cb_GiaTri.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            cb_GiaTri.DisplayMember = cb_TenTruong.Text;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT KiemKe.MaKK, KiemKe.NgayKK, KiemKe.MaNV, ChiTietKiemKe.MaTTB, TrangThietBi.TenTTB, ChiTietKiemKe.MaTT, ChiTietKiemKe.GhiChu "+
            "FROM KiemKe " +
            "INNER JOIN ChiTietKiemKe ON KiemKe.MaKK = ChiTietKiemKe.MaKK " +
            "INNER JOIN TrangThietBi ON ChiTietKiemKe.MaTTB = TrangThietBi.MaTTB where " + TenTruong + " = '" + cb_GiaTri.Text + "'";
            grd_exportKiemKe.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_GiaTri.Text == "")
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = @"SELECT KK.MaKK, KK.NgayKK, KK.MaNV, CTKK.MaTTB, TTB.TenTTB, CTKK.MaTT, CTKK.GhiChu
                    FROM KiemKe KK
                    INNER JOIN ChiTietKiemKe CTKK ON KK.MaKK = CTKK.MaKK
                    INNER JOIN TrangThietBi TTB ON CTKK.MaTTB = TTB.MaTTB";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dtBC = new DataTable();
                        da.Fill(dtBC);

                        rptKiemKe bc = new rptKiemKe();
                        bc.SetDataSource(dtBC);
                        //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cb_TenTruong.Text + "'";
                        //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cb_GiaTri.Text + "'";
                        frmrptKiemKe f = new frmrptKiemKe(bc);
                        f.Show();
                    }
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT KiemKe.MaKK, KiemKe.NgayKK, KiemKe.MaNV, ChiTietKiemKe.MaTTB, TrangThietBi.TenTTB, ChiTietKiemKe.MaTT, ChiTietKiemKe.GhiChu " +
                    "FROM KiemKe " +
                    "INNER JOIN ChiTietKiemKe ON KiemKe.MaKK = ChiTietKiemKe.MaKK " +
                    "INNER JOIN TrangThietBi ON ChiTietKiemKe.MaTTB = TrangThietBi.MaTTB where " + TenTruong + " = '" + cb_GiaTri.Text + "'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dtBC = new DataTable();
                        da.Fill(dtBC);

                        rptKiemKe bc = new rptKiemKe();
                        bc.SetDataSource(dtBC);
                        bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cb_TenTruong.Text + "'";
                        bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cb_GiaTri.Text + "'";
                        frmrptKiemKe f = new frmrptKiemKe(bc);
                        f.Show();
                    }
                }
            }
        }
    }
}
