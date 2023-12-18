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
    public partial class DatPhongHo : Form
    {
        string MaPhong, TenPhong, taikhoan, MaNV, MaDP = "MDP";

        private void DatPhongHo_Load(object sender, EventArgs e)
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
        }

        int SL, SoLuong;
        public DatPhongHo()
        {
            InitializeComponent();
        }

        public DatPhongHo(string maPhong, string tenPhong, int sl) : this()
        {
            TenPhong = tenPhong;
            MaPhong = maPhong;
            SoLuong = sl;
        }
        private void tb_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đặt phòng này?", "Xác nhận đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                try
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
                    string sql = $"INSERT INTO DatPhong (MaDP, ThoiGianDat, ThoiGianMuon, ThoiGianTra, MaPhong, MaNV) VALUES('{MaDP}', '{TG_Dat}', '{classMain.TG_Muon}', '{classMain.TG_Tra}', '{MaPhong}', '{txt_MaNV.Text}')";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                    MessageBox.Show("Đặt phòng thành công");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thành công");
                }
                
            }
        }
    }
}
