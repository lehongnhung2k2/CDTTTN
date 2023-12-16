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
    public partial class editPhong : UserControl
    {
        string MA_PHONG, TEN_PHONG;

        public editPhong()
        {
            InitializeComponent();
        }

        public void NapCT()
        {
            txt_MaPhong.ReadOnly = true;
            txt_TenPhong.ReadOnly = false;
            txt_SoLuong.ReadOnly = false;

            int i = grd_Phong.CurrentRow.Index;
            txt_MaPhong.Text = grd_Phong.Rows[i].Cells["MaPhong"].Value.ToString();
            txt_TenPhong.Text = grd_Phong.Rows[i].Cells["TenPhong"].Value.ToString();
            txt_SoLuong.Text = grd_Phong.Rows[i].Cells["SoLuong"].Value.ToString();
            TEN_PHONG = grd_Phong.Rows[i].Cells["TenPhong"].Value.ToString();
            MA_PHONG = grd_Phong.Rows[i].Cells["MaPhong"].Value.ToString();
        }

       

        private void editPhong_Load(object sender, EventArgs e)
        {
            string sql = "select MaPhong, TenPhong, SoLuong from Phong";
            grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);

            NapCT();
        }

        private void grd_Phong_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grd_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin chỉnh sửa?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                string MaPhong = txt_MaPhong.Text;
                string TenPhong = txt_TenPhong.Text;
                int SoLuong;
                if (int.TryParse(txt_SoLuong.Text, out SoLuong)) { }
                else { }

                string sql = "UPDATE Phong SET TenPhong = N'" + TenPhong + "', SoLuong = " + SoLuong + " WHERE MaPhong = '" + MaPhong +"'";
                grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);

                sql = "select MaPhong, TenPhong, SoLuong from Phong";
                grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                string MaPhong = txt_MaPhong.Text;
                
                string sql = "DELETE FROM Phong WHERE MaPhong = '" + MaPhong + "'";
                grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);

                sql = "select MaPhong, TenPhong, SoLuong from Phong";
                grd_Phong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editTTBTrongPhong f = new editTTBTrongPhong(MA_PHONG, TEN_PHONG);
            f.Show();
        }
    }
}
