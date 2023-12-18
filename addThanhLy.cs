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
    public partial class addThanhLy : UserControl
    {
        public addThanhLy()
        {
            InitializeComponent();
        }

        private void addThanhLy_Load(object sender, EventArgs e)
        {
            txt_GhiChu.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm danh mục thanh lý trang thiết bị này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"INSERT INTO ThanhLy (MaTL, NgayTL, NguoiMua, GhiChu, MaTTB, MaNV, GiaTL) VALUES ('{txt_MaTL.Text}', '{txt_NgayTL.Text}', N'{txt_NguoiMua.Text}', N'{txt_GhiChu.Text}', '{txt_MaTTB.Text}', '{txt_MaNV.Text}', {txt_GiaTL.Text})";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    sql = $"UPDATE TrangThietBi SET MaTT = 'TT003' FROM TrangThietBi INNER JOIN ThanhLy ON TrangThietBi.MaTTB = ThanhLy.MaTTB WHERE ThanhLy.MaTTB = '{txt_MaTTB}'";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    MessageBox.Show("Thêm thanh lý trang thiết bị thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }
    }
}
