using CDTTTN.DAO;
using CDTTTN.DTO;
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
    public partial class DatPhong : UserControl
    {
        public DatPhong()
        {
            InitializeComponent();
            LoadPhong();
        }

        //#region Method
        void LoadPhong()
        {
           List<Phong> phongList = PhongDAO.Instance.LoadPhongList();

            foreach (Phong item in phongList)
            {
                Button btn = new Button() { Width = PhongDAO.PhongDai, Height = PhongDAO.PhongRong };
                btn.Text = item.TenPhong + Environment.NewLine + item.TrangThai;
                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(155, 218, 246);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(228, 228, 228);
                }
                flp_Phong.Controls.Add(btn);
            }
        }
        //#endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
