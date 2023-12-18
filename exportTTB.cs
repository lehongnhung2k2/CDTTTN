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
    public partial class exportTTB : UserControl
    {

        public exportTTB()
        {
            InitializeComponent();
        }

        private void exportTTB_Load(object sender, EventArgs e)
        {

            string sql = "select MaTTB, TenTTB, NgayNhap, ThoiGianTinhKhauHao, Thue, NguyenGia, MaTT, MaNCC, MaNV from TrangThietBi";
            grd_exportTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_GiaTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_TenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "select distinct " + cb_TenTruong.Text + " from TrangThietBi";

            cb_GiaTri.DataSource = DataProvider.Instance.ExcuteQuery(sql1);
            cb_GiaTri.DisplayMember = cb_TenTruong.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_GiaTri.Text == "")
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "select MaTTB, TenTTB, NgayNhap, ThoiGianTinhKhauHao, Thue, NguyenGia, MaTT, MaNCC, MaNV from TrangThietBi";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dtBC = new DataTable();
                        da.Fill(dtBC);

                        rptTrangThietBi bc = new rptTrangThietBi();
                        bc.SetDataSource(dtBC);
                        //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cb_TenTruong.Text + "'";
                        //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cb_GiaTri.Text + "'";
                        frmrptTrangThietBi f = new frmrptTrangThietBi(bc);
                        f.Show();
                    }
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "select MaTTB, TenTTB, NgayNhap, ThoiGianTinhKhauHao, Thue, NguyenGia, MaTT, MaNCC, MaNV from TrangThietBi where " + cb_TenTruong.Text + " = '" + cb_GiaTri.Text + "'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dtBC = new DataTable();
                        da.Fill(dtBC);

                        rptTrangThietBi bc = new rptTrangThietBi();
                        bc.SetDataSource(dtBC);
                        bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cb_TenTruong.Text + "'";
                        bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cb_GiaTri.Text + "'";
                        frmrptTrangThietBi f = new frmrptTrangThietBi(bc);
                        f.Show();
                    }
                }
            }

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select MaTTB, TenTTB, NgayNhap, ThoiGianTinhKhauHao, Thue, NguyenGia, MaTT, MaNCC, MaNV from TrangThietBi where " + cb_TenTruong.Text + " = '" + cb_GiaTri.Text + "'";
            grd_exportTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
