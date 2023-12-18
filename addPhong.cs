using CDTTTN.DAO;
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
    public partial class addPhong : UserControl
    {
        public addPhong()
        {
            InitializeComponent();

        }

        private void addPhong_Load(object sender, EventArgs e)
        {
            string sql = "select MaPhong, TenPhong, SoLuong from Phong";
            grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string MaPhong = txt_MaPhong.Text;
            string TenPhong = txt_TenPhong.Text;
            int SoLuong;
            if (int.TryParse(txt_SoLuong.Text, out SoLuong)) { }
            else { }
            try
            {
                string sql = "INSERT INTO Phong (MaPhong, TenPhong, SoLuong, TrangThaiPhong) VALUES ('"
                + MaPhong + "', N'" + TenPhong + "', " + SoLuong + ", N'Trống')";
                grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);

                sql = "select MaPhong, TenPhong, SoLuong from Phong";
                grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
            
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {

        }
    }
}
