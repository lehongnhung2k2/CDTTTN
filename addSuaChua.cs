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
    public partial class addSuaChua : UserControl
    {
        public addSuaChua()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm mới sửa chữa trang thiết bị này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"INSERT INTO SuaChua (MaSC, NgaySC, GiaSC, GhiChu, MaTTB, MaNV) VALUES ('{txt_MaSC.Text}', '{txt_NgaySC.Text}', {txt_GiaSC.Text}, N'{txt_GhiChu.Text}', '{txt_MaTTB.Text}', '{txt_MaNV}')";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    MessageBox.Show("Thêm danh mục sửa chữa trang thiết bị thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thành công");
                }
                
            }
        }

        private void addSuaChua_Load(object sender, EventArgs e)
        {

        }
    }
}
