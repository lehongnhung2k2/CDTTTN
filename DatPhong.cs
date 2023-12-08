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
        string MaPhong, TenPhong, taikhoan;
        public DatPhong()
        {
            InitializeComponent();
            LoadPhong();
            SetDateTimePickerToCurrentTime();
        }

        //public DatPhong(string tk) : this()
        //{
        //    taikhoan = tk;
        //}

        //#region Method
        void LoadPhong()
        {
            
            DateTime T1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            DateTime T2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            

            List<Phong> phongList = PhongDAO.Instance.LoadPhongList();

            foreach (Phong item in phongList)
            {
                string MaPhong = item.MaPhong;
                string TrangThaiPhong = item.TrangThai;
                string sql;
                if (TrangThaiPhong == "Đã được đặt")
                {
                    sql = $"update Phong set TrangThaiPhong = N'Trống' where MaPhong = '{MaPhong}'";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                }    
                
                
                Button btn = new Button() { Width = PhongDAO.PhongDai, Height = PhongDAO.PhongRong };
                btn.Text = item.TenPhong + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                

                List<DatPhongDTO> datphongList = DatPhongDAO.Instance.LoadDatPhongList();
                foreach (DatPhongDTO item1 in datphongList)
                {
                    DateTime T3 = new DateTime(item1.ThoiGianMuon.Year, item1.ThoiGianMuon.Month, item1.ThoiGianMuon.Day, item1.ThoiGianMuon.Hour, item1.ThoiGianMuon.Minute, item1.ThoiGianMuon.Second);
                    DateTime T4 = new DateTime(item1.ThoiGianTra.Year, item1.ThoiGianTra.Month, item1.ThoiGianTra.Day, item1.ThoiGianTra.Hour, item1.ThoiGianTra.Minute, item1.ThoiGianTra.Second);

                    if (T1 >= T3 && T1 <= T4 && T2 >= T3 && T2 <= T4)
                    {
                        sql = $"update Phong set TrangThaiPhong = N'Đã được đặt' where MaPhong = '{MaPhong}'";
                        grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    }  
                }


                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(240, 156, 164);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(228, 228, 228);
                    btn.Enabled = false;
                }
                flp_Phong.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Phong selectedPhong = (Phong)((Button)sender).Tag;
            MaPhong = selectedPhong.MaPhong;
            TenPhong = selectedPhong.TenPhong;
            int SoLuong = selectedPhong.SoLuong;
            GiaoDienDatPhong f = new GiaoDienDatPhong(MaPhong, TenPhong, SoLuong, time_start.Value, time_end.Value);
            f.Show();
        }


        //#endregion
        private void SetDateTimePickerToCurrentTime()
        {
            // Đặt DateTimePicker thành thời gian hiện tại
            time_start.Value = DateTime.Now;
            time_end.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            time_start.Format = DateTimePickerFormat.Custom;
            time_start.CustomFormat = "HH:mm";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            time_end.Format = DateTimePickerFormat.Custom;
            time_end.CustomFormat = "HH:mm";
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(classMain.TENTAIKHOAN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flp_Phong.Controls.Clear();
            DateTime T1 = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, time_start.Value.Hour, time_start.Value.Minute, 0);
            DateTime T2 = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, time_end.Value.Hour, time_end.Value.Minute, 0);

            List<Phong> phongList = PhongDAO.Instance.LoadPhongList();

            foreach (Phong item in phongList)
            {
                string MaPhong = item.MaPhong;
                string TrangThaiPhong = item.TrangThai;
                string sql;
                if (TrangThaiPhong == "Đã được đặt")
                {
                    sql = $"update Phong set TrangThaiPhong = N'Trống' where MaPhong = '{MaPhong}'";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                }


                Button btn = new Button() { Width = PhongDAO.PhongDai, Height = PhongDAO.PhongRong };
                btn.Text = item.TenPhong + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;


                List<DatPhongDTO> datphongList = DatPhongDAO.Instance.LoadDatPhongList();
                foreach (DatPhongDTO item1 in datphongList)
                {
                    DateTime T3 = new DateTime(item1.ThoiGianMuon.Year, item1.ThoiGianMuon.Month, item1.ThoiGianMuon.Day, item1.ThoiGianMuon.Hour, item1.ThoiGianMuon.Minute, item1.ThoiGianMuon.Second);
                    DateTime T4 = new DateTime(item1.ThoiGianTra.Year, item1.ThoiGianTra.Month, item1.ThoiGianTra.Day, item1.ThoiGianTra.Hour, item1.ThoiGianTra.Minute, item1.ThoiGianTra.Second);

                    if (T1 >= T3 && T1 <= T4 && T2 >= T3 && T2 <= T4)
                    {
                        sql = $"update Phong set TrangThaiPhong = N'Đã được đặt' where MaPhong = '{MaPhong}'";
                        grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    }
                }


                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(240, 156, 164);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(228, 228, 228);
                    btn.Enabled = false;
                }
                flp_Phong.Controls.Add(btn);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
