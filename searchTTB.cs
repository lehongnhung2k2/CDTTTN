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
        //SqlConnection conn = new SqlConnection();
        //SqlDataAdapter da = new SqlDataAdapter();
        //SqlCommand cmd = new SqlCommand();
        //DataTable dt = new DataTable();
        //string sql, constr;
        //int i;
        public searchTTB()
        {
            InitializeComponent();
        }

        private void btn_TimKiemTTB_Click(object sender, EventArgs e)
        {
            string mattb, trangthai, ngaynhap, tenttb, mancc, manv;
            if (txt_MaTTB.Text == "")
            {
                mattb = "*";
            }
            else mattb = txt_MaTTB.Text;
            if (txt_TrangThai.Text == "")
            {
                trangthai = "*";
            }
            else trangthai = txt_TrangThai.Text;
            if (txt_NgayNhap.Text == "")
            {
                ngaynhap = "*";
            }
            else ngaynhap = txt_NgayNhap.Text;
            if (txt_TTB.Text == "")
            {
                tenttb = "*";
            }
            else tenttb = txt_TTB.Text;
            if (txt_MaNCC.Text == "")
            {
                mancc = "*";
            }
            else mancc = txt_MaNCC.Text;
            if (txt_MaNV.Text == "")
            {
                manv = "*";
            }
            else manv = txt_MaNV.Text;

            //sql = "SELECT * FROM TrangThietBi WHERE "
            //    + "(MaTTB = '" + mattb + "' OR MaTTB IS NOT NULL)"
            //    + "AND(TenTTB = '" + tenttb + "' OR TenTTB IS NOT NULL)";
                //+ "AND(MaTT = '" + trangthai + "' OR MaTT IS NOT NULL)"
                //+ "AND(MaNCC = '" + mancc + "' OR MaNCC IS NOT NULL)"
                //+ "AND(MaNV = '" + manv + "' OR MaNV IS NOT NULL)"
                //+ "AND(NgayNhap = '" + ngaynhap + "' OR NgayNhap IS NOT NULL)";
            //sql = "select * from TrangThietBi "
            //    + " where " + "MaTTB" + "=N'" + mattb + "'"
            //    + " and " + "TenTTB" + "=N'" + tenttb + "'"
            //    + " and " + " MaTT" + "=N'" + trangthai + "'"
            //    + " and " + " MaNCC" + "=N'" + mancc + "'"
            //    + " and " + " MaNV" + "=N'" + manv + "'";
            //truyen da cau lenh sql va ket noi toi conn
            //da = new SqlDataAdapter(sql, conn);
            //dt = new DataTable();
            //dt.Clear();
            //da.Fill(dt);
            //grdTTB.DataSource = dt;

        }

        private void searchTTB_Load(object sender, EventArgs e)
        {
            string sql = "select * from TrangThietBi";
            //DataProvider provider = new DataProvider();

            grdTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
