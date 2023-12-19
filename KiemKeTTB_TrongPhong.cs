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
    public partial class KiemKeTTB_TrongPhong : Form
    {
        string MaDP, MaPhong, TinhTrang, MaKKP = "KKP";
        int n, SL;
        List<string> maTTB = new List<string>();
        List<string> tinhTrang = new List<string>();
        List<string> ghiChu = new List<string>();
        public KiemKeTTB_TrongPhong()
        {
            InitializeComponent();
        }

        public KiemKeTTB_TrongPhong(string maDP, string maPhong) : this()
        {
            MaDP = maDP;
            MaPhong = maPhong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SLKK();
                set_MaKKP();
                set_GT();
                Console.WriteLine(MaKKP);
                for (int i = 0; i < n - 1; i++)
                {
                    Console.WriteLine(tinhTrang[i]);
                    string sql1 = $"INSERT INTO ChiTietKiemKePhong (MaKKP, TinhTrang, GhiChu, MaTTB) VALUES ('{MaKKP}', N'{tinhTrang[i]}', N'{ghiChu[i]}', '{maTTB[i]}')";
                    grd.DataSource = DataProvider.Instance.ExcuteQuery(sql1);
                }
                string sql = $"INSERT INTO KiemKePhong (MaKKP, MaDP) VALUES ('{MaKKP}', '{MaDP}')";
                grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                MessageBox.Show("Kiểm kê trang thiết bị thành công");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
            
            
        }

        private void KiemKeTTB_TrongPhong_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT TrangThietBi.MaTTB, TrangThietBi.TenTTB FROM TTBTrongPhong INNER JOIN TrangThietBi ON TTBTrongPhong.MaTTB = TrangThietBi.MaTTB WHERE TTBTrongPhong.MaPhong = '{MaPhong}'";
            grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            n = grd.RowCount;
        }

        private void SLKK()
        {
            string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo truy vấn SQL để lấy số lượng bản ghi trong bảng
                string query = "SELECT COUNT(*) FROM KiemKePhong";

                // Tạo và thực hiện SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // ExecuteScalar sẽ trả về giá trị đầu tiên của kết quả truy vấn
                    SL = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        private void set_MaKKP()
        {
            ++SL;
            if (SL >= 0 && SL <= 9)
            {
                MaKKP += "00";
                MaKKP += SL.ToString();
            }
            else if (SL >= 10 && SL <= 99)
            {
                MaKKP += "0";
                MaKKP += SL.ToString();
            }
            else
            {
                MaKKP += SL.ToString();
            }
        }
        private void set_GT()
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (Convert.ToBoolean(grd.Rows[i].Cells[0].Value) == true)
                {
                    tinhTrang.Add("Đủ");
                    DataGridViewCell cell = grd.Rows[i].Cells[2];
                    if (cell.Value != null)
                    {
                        ghiChu.Add(grd.Rows[i].Cells[2].Value.ToString());
                    }
                    ghiChu.Add("");
                    maTTB.Add(grd.Rows[i].Cells[3].Value.ToString());
                   
                }
                else if (Convert.ToBoolean(grd.Rows[i].Cells[1].Value) == true)
                {
                    tinhTrang.Add("Thiếu");
                    DataGridViewCell cell = grd.Rows[i].Cells[2];
                    if (cell.Value != null)
                    {
                        ghiChu.Add(grd.Rows[i].Cells[2].Value.ToString());
                    }
                    ghiChu.Add("");
                    maTTB.Add(grd.Rows[i].Cells[3].Value.ToString());
                    
                }

                //Console.WriteLine(ghiChu);
            }
        }
    }
}
