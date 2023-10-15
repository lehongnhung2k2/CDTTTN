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
    public partial class TaiKhoanCuaToi : UserControl
    {
        public TaiKhoanCuaToi()
        {
            InitializeComponent();
        }

        private void TaiKhoanCuaToi_Load(object sender, EventArgs e)
        {
            tb_TaiKhoan.Text = "nhunghongle";
            tb_HoTen.Text = "Lê Hồng Nhung";
            tb_NgaySinh.Text = "26/03/2002";
            tb_GioiTinh.Text = "Nữ";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_edit.Text == "Sửa thông tin")
            {
                btn_edit.Text = "Lưu";
                tb_TaiKhoan.ReadOnly = false;
                tb_HoTen.ReadOnly = false;
                tb_GioiTinh.ReadOnly = false;
                tb_NgaySinh.ReadOnly = false;
            }    
            else
            {
                btn_edit.Text = "Sửa thông tin";
                tb_TaiKhoan.ReadOnly = true;
                tb_HoTen.ReadOnly = true;
                tb_GioiTinh.ReadOnly = true;
                tb_NgaySinh.ReadOnly = true;
            }    
            
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.Show();
        }
    }
}
