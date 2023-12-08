using CDTTTN.DAO;
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
    public partial class GiaoDienDatPhong : Form
    {
        string MaPhong, TenPhong, taikhoan, MaNV, MaDP = "MDP";
        DateTime TG_Muon, TG_Tra;
        int SL;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt phòng này?", "Xác nhận đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                ++SL;
                if (SL >= 0 && SL <= 9)
                {
                    MaDP += "00";
                    MaDP += SL.ToString();
                }
                else if (SL >= 10 && SL <= 99)
                {
                    MaDP += "0";
                    MaDP += SL.ToString();
                }
                else
                {
                    MaDP += SL.ToString();
                }

                DateTime TG_Dat = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                string sql = $"INSERT INTO DatPhong (MaDP, ThoiGianDat, ThoiGianMuon, ThoiGianTra, MaPhong, MaNV) VALUES('{MaDP}', '{TG_Dat}', '{TG_Muon}', '{TG_Tra}', '{MaPhong}', '{classMain.MANV}')";
                grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                MessageBox.Show("Đặt phòng thành công");
                this.Close();
            }
            
            
        }

        int SoLuong;
        public GiaoDienDatPhong()
        {
            InitializeComponent();
        }


        public GiaoDienDatPhong(string maPhong, string tenPhong, int sl, DateTime TGMuon, DateTime TGTra) : this()
        {
            TenPhong = tenPhong;
            MaPhong = maPhong;
            TG_Muon = TGMuon;
            TG_Tra = TGTra;
            SoLuong = sl;
        }

        private void GiaoDienDatPhong_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo truy vấn SQL để lấy số lượng bản ghi trong bảng
                string query = "SELECT COUNT(*) FROM DatPhong";

                // Tạo và thực hiện SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // ExecuteScalar sẽ trả về giá trị đầu tiên của kết quả truy vấn
                    SL = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            txt_TenPhong.Text = TenPhong;
            txt_TrangThai.Text = "Trống";
            txt_SoLuong.Text = SoLuong.ToString();
            txt_TGMuon.Text = TG_Muon.ToString();
            txt_TGTra.Text = TG_Tra.ToString();
            

            
        }
    }
}
