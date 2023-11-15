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

        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            if (btn_SuaThongTin.Text == "Sửa thông tin")
            {
                btn_SuaThongTin.Text = "Lưu";
                tb_HoTen.ReadOnly = false;
                tb_GioiTinh.ReadOnly = false;
                tb_NgaySinh.ReadOnly = false;
                tb_Email.ReadOnly = false;
                tb_sdt.ReadOnly = false;
                tb_DiaChi.ReadOnly = false;
            }    
            else
            {
                btn_SuaThongTin.Text = "Sửa thông tin";
                tb_HoTen.ReadOnly = true;
                tb_GioiTinh.ReadOnly = true;
                tb_NgaySinh.ReadOnly = true;
                tb_Email.ReadOnly = true;
                tb_sdt.ReadOnly = true;
                tb_DiaChi.ReadOnly = true;
            }    
            
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.Show();
        }
    }
}
