using CDTTTN.DAO;
using CDTTTN.DTO;
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
    public partial class DatPhong : UserControl
    {
        string MaPhong, TenPhong, taikhoan, TrangThaiPhong, maDP;
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
            
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Phong selectedPhong = (Phong)((Button)sender).Tag;
            MaPhong = selectedPhong.MaPhong;
            TenPhong = selectedPhong.TenPhong;
            int SoLuong = selectedPhong.SoLuong;
            TrangThaiPhong = selectedPhong.TrangThai;
            
            classMain.TG_Muon = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, time_start.Value.Hour, time_start.Value.Minute, 0);
            classMain.TG_Tra = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, time_end.Value.Hour, time_end.Value.Minute, 0);
            if (TrangThaiPhong == "Trống")
            {
                GiaoDienDatPhong f = new GiaoDienDatPhong(MaPhong, TenPhong, SoLuong);
                f.Show();
            }    
            else 
            {
                try
                {
                    //DateTime TG_Now = DateTime.Now;
                    string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
                    string maNV = classMain.MANV;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Lấy thời gian hiện tại
                        DateTime thoiGianHienTai = DateTime.Now;

                        // Tạo và thực thi câu lệnh SQL để lấy MaDP khi thời gian hiện tại nằm trong khoảng từ ThoiGianMuon đến ThoiGianTra và MaNV = maNV
                        string query = "SELECT MaDP FROM DatPhong WHERE @ThoiGianHienTai BETWEEN ThoiGianMuon AND ThoiGianTra AND MaNV = @MaNV";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số cho thời gian hiện tại và MaNV
                            command.Parameters.AddWithValue("@ThoiGianHienTai", thoiGianHienTai);
                            command.Parameters.AddWithValue("@MaNV", maNV);

                            // Thực hiện truy vấn và đọc kết quả
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Lấy giá trị MaDP từ kết quả
                                    maDP = reader["MaDP"].ToString();


                                }
                            }
                        }
                    }
                    KiemKeTTB_TrongPhong f = new KiemKeTTB_TrongPhong(maDP, MaPhong);
                    f.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thành công");
                }
                
            }    
            
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
            flp_Phong.Controls.Clear();
            DateTime T = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            DateTime T1 = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, time_start.Value.Hour, time_start.Value.Minute, 0);
            DateTime T2 = new DateTime(date.Value.Year, date.Value.Month, date.Value.Day, time_end.Value.Hour, time_end.Value.Minute, 0);

            List<Phong> phongList = PhongDAO.Instance.LoadPhongList();

            foreach (Phong item in phongList)
            {
                string MaPhong = item.MaPhong;
                string TrangThaiPhong = item.TrangThai;
                string sql;
                if (TrangThaiPhong != "Trống")
                {
                    sql = $"update Phong set TrangThaiPhong = N'Trống' where MaPhong = '{MaPhong}'";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                }


                Button btn = new Button() { Width = PhongDAO.PhongDai, Height = PhongDAO.PhongRong };
                


                List<DatPhongDTO> datphongList = DatPhongDAO.Instance.LoadDatPhongList();
                foreach (DatPhongDTO item1 in datphongList)
                {

                    DateTime T3 = new DateTime(item1.ThoiGianMuon.Year, item1.ThoiGianMuon.Month, item1.ThoiGianMuon.Day, item1.ThoiGianMuon.Hour, item1.ThoiGianMuon.Minute, 0);
                    DateTime T4 = new DateTime(item1.ThoiGianTra.Year, item1.ThoiGianTra.Month, item1.ThoiGianTra.Day, item1.ThoiGianTra.Hour, item1.ThoiGianTra.Minute, 0);
                    if (item1.MaPhong == MaPhong)
                    {
                        if (T2 <= T3 || T1 >= T4)
                        {

                            //Console.WriteLine("Trống");
                        }
                        else if (T >= T3 && T <=T4 && item1.MaNV == classMain.MANV)
                        {
                            sql = $"update Phong set TrangThaiPhong = N'Bạn đang sử dụng' where MaPhong = '{MaPhong}'";
                            grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                        }
                        else
                        {
                            sql = $"update Phong set TrangThaiPhong = N'Đã được đặt' where MaPhong = '{MaPhong}'";
                            grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                        }
                    }

                }


                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(240, 156, 164);
                }
                else if (item.TrangThai == "Đã được đặt")
                {
                    btn.BackColor = Color.FromArgb(228, 228, 228);
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(156, 208, 148); 
                }
                btn.Text = item.TenPhong + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                flp_Phong.Controls.Add(btn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flp_Phong.Controls.Clear();
            DateTime T = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
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
                

                List<DatPhongDTO> datphongList = DatPhongDAO.Instance.LoadDatPhongList();
                foreach (DatPhongDTO item1 in datphongList)
                {
                    
                    DateTime T3 = new DateTime(item1.ThoiGianMuon.Year, item1.ThoiGianMuon.Month, item1.ThoiGianMuon.Day, item1.ThoiGianMuon.Hour, item1.ThoiGianMuon.Minute, 0);
                    DateTime T4 = new DateTime(item1.ThoiGianTra.Year, item1.ThoiGianTra.Month, item1.ThoiGianTra.Day, item1.ThoiGianTra.Hour, item1.ThoiGianTra.Minute, 0);
                    

                    if (item1.MaPhong == MaPhong)
                    {
                        if (T2 <= T3 || T1 >= T4)
                        {

                            //Console.WriteLine("Trống");
                        }
                        else if (T >= T3 && T <= T4 && item1.MaNV == classMain.MANV)
                        {
                            sql = $"update Phong set TrangThaiPhong = N'Bạn đang sử dụng' where MaPhong = '{MaPhong}'";
                            grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                        }
                        else
                        {
                            sql = $"update Phong set TrangThaiPhong = N'Đã được đặt' where MaPhong = '{MaPhong}'";
                            grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                        }
                    }

                }


                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(240, 156, 164);
                }
                else if (item.TrangThai == "Đã được đặt")
                {
                    btn.BackColor = Color.FromArgb(228, 228, 228);
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(156, 208, 148);
                }
                btn.Text = item.TenPhong + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                flp_Phong.Controls.Add(btn);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
