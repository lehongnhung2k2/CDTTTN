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
    public partial class KiemKeTTBTrongPhong : Form
    {
        string MaPhong, MaKKP="KKP", TinhTrang, MaTTB, GhiChu, MaDP;
        int SL, n;
        bool Checked = false;
        List<string> maTTB = new List<string>();
        List<string> tinhTrang = new List<string>();
        List<string> ghiChu = new List<string>();
        public KiemKeTTBTrongPhong()
        {
            InitializeComponent();
        }
        public KiemKeTTBTrongPhong(string maDP, string maPhong) : this()
        {
            MaDP = maDP;
            MaPhong = maPhong;
        }

        private void KiemKeTTBTrongPhong_Load(object sender, EventArgs e)
        {

            string sql = $"SELECT TrangThietBi.MaTTB, TrangThietBi.TenTTB FROM TTBTrongPhong INNER JOIN TrangThietBi ON TTBTrongPhong.MaTTB = TrangThietBi.MaTTB WHERE TTBTrongPhong.MaPhong = '{MaPhong}'";
            grd_KiemKeTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);


            DataGridViewCheckBoxColumn check_box1 = new DataGridViewCheckBoxColumn();
            check_box1.HeaderText = "Thiếu";
            check_box1.Name = "thieu";
            check_box1.Width = 100;
            check_box1.ReadOnly = false;
            grd_KiemKeTTB.Columns.Insert(0, check_box1);

            DataGridViewCheckBoxColumn check_box2 = new DataGridViewCheckBoxColumn();
            check_box2.HeaderText = "Đủ";
            check_box2.Name = "du";
            check_box2.Width = 100;
            check_box2.ReadOnly = false;
            grd_KiemKeTTB.Columns.Insert(0, check_box2);

            //DataGridViewTextBoxColumn ghichu = new DataGridViewTextBoxColumn();
            //ghichu.HeaderText = "Ghi chú";
            //ghichu.Name = "ghichu";

            //// Thêm cột vào cột cuối cùng của DataGridView
            //grd_KiemKeTTB.Columns.Add(ghichu);



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
            n = grd_KiemKeTTB.RowCount;

            // Access the DataTable bound to the DataGridView
            DataTable dataTable = (DataTable)grd_KiemKeTTB.DataSource;

            // Create a list to store the MaTTB values
            

            // Iterate through each row in the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Access the "MaTTB" column value for each row
                string maTTBValue = row["MaTTB"].ToString();
                maTTB.Add(maTTBValue);
                //Console.WriteLine(row["du"].ToString());
            }

            //Console.WriteLine(maTTBValues[1]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            set_MaKKP();
            string sql = $"INSERT INTO KiemKePhong (MaKKP, MaDP) VALUES ('{MaKKP}', '{MaDP}')";
            grd_KiemKeTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);


            //if (grd_KiemKeTTB.Rows[0].Cells[0].Value != null) Console.WriteLine("Nhung");

            for (int i = 0; i < n - 1; i++)
            {

                //set_GhiChu(i);
                set_TrangThai(i);
                //MaTTB = maTTB[i];


                //if (Checked)
                //{
                //    //Console.WriteLine(MaKKP, TinhTrang, GhiChu, MaTTB);
                //    sql = $"INSERT INTO ChiTietKiemKePhong (MaKKP, TinhTrang, GhiChu, MaTTB) VALUES ('{MaKKP}', N'{TinhTrang}', N'{GhiChu}', '{MaTTB}')";
                //    grd_KiemKeTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                //    MessageBox.Show("Hoàn thành");
                //}
                //else
                //{
                //    --SL;
                //    MessageBox.Show("Không thành công");
                //}
            }


        }

        //private void set_MaTTB(int i)
        //{
        //    MaTTB = grd_KiemKeTTB.Rows[i].Cells["MaTTB"].Value.ToString();
        //    Console.WriteLine(MaTTB);
        //}
        private void set_TrangThai(int i)
        {
            Console.WriteLine(i);
            if (i >= 0 && i < n)
            {
                // Access the row and perform the desired operation
                if (Convert.ToBoolean(grd_KiemKeTTB.Rows[i].Cells["thieu"].Value) == true)
                {
                    Console.WriteLine("Nhung");
                }
            }
            else
            {
                // Handle the case where the index is out of range
                Console.WriteLine("Index out of range: " + i);
            }

            //Checked = false;
            //if (Convert.ToBoolean(grd_KiemKeTTB.Rows[i].Cells["thieu"].Value) == true)
            //{
            //    TinhTrang = "Thiếu";
            //    Checked = true;
            //    Console.WriteLine("Tinhf tranjf");
            //}
            //if (Convert.ToBoolean(grd_KiemKeTTB.Rows[i].Cells["du"].Value) == true)
            //{
            //    TinhTrang = "Đủ";
            //    Checked = true;
            //    Console.WriteLine("Tinhf tranjf");
            //}
        }
        private void set_GhiChu(int i)
        {
            if (grd_KiemKeTTB.Rows[i].Cells["ghichu"].Value != null)
            {
                GhiChu = grd_KiemKeTTB.Rows[i].Cells["ghichu"].Value.ToString();
            }
            else
            {
                GhiChu = "";
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
    }
}
