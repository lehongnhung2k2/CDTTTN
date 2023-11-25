using CDTTTN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDTTTN
{
    public partial class editTTBTrongPhong : Form
    {
        string MaTTB, TenTTB;
        string MA_PHONG, TEN_PHONG;

        public editTTBTrongPhong()
        {
            InitializeComponent();
            
            LoadTenTTB();
            NapCT();

        }

        public editTTBTrongPhong(string MaPhong, string TenPhong) : this()
        {
            MA_PHONG = MaPhong;
            TEN_PHONG = TenPhong;

        }



        public void NapCT()
        {
            if (grd_TTB.CurrentRow != null)
            {
                int i = grd_TTB.CurrentRow.Index;
                MaTTB = grd_TTB.Rows[i].Cells["MaTTB"].Value.ToString();
                TenTTB = grd_TTB.Rows[i].Cells["MaTTB"].Value.ToString();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //DataTable data = DataProvider.Instance.ExcuteQuery(sql);

            //comboBox1.DataSource = data;
            //comboBox1.DisplayMember = "TenTTB";
        }
        private void LoadTenTTB()
        {
            string constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            string sql = "select distinct TenTTB from TrangThietBi";

            var dataTable = new System.Data.DataTable();

            // Tạo kết nối và adapter
            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Sử dụng SqlDataAdapter để đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            // Thiết lập ComboBox
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "TenTTB";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string TenTTB = comboBox1.Text;
            //string sql = "select * from TrangThietBi";
            string sql = "select MaTTB, TenTTB from TrangThietBi where TenTTB = N'" + TenTTB + "' and TrangThaiTrongPhong = 0";
            grd_TTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }

        private void grd_TTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //editPhong editphong = new editPhong();
            //string TenPhong = editphong.TENPHONG;
            //string MaPhong = editphong.MAPHONG;
            DialogResult result = MessageBox.Show("Bạn có muốn thêm trang thiết bị vào phòng này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                //them ttb vao phong
                string sql = "INSERT INTO TTBTrongPhong (MaPhong, MaTTB, TrangThaiTrongPhong) VALUES ('" + MA_PHONG + "', '" + MaTTB + "', 1)";
                grd_TTBPhong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                //hien ttb trong phong
                sql = "select * from TTBTrongPhong";
                grd_TTBPhong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
                //hien ttb
                //string sql1 = "select * from TrangThietBi";
                string sql1 = "update TrangThietBi set TrangThaiTrongPhong = 1 where MaTTB = '" + MaTTB + "'";
                grd_TTB.DataSource = DataProvider.Instance.ExcuteQuery(sql1);
                sql1 = "select MaTTB, TenTTB from TrangThietBi where TenTTB = N'" + TenTTB + "' and TrangThaiTrongPhong = 0";
                grd_TTB.DataSource = DataProvider.Instance.ExcuteQuery(sql1);

            }
        }

        private void editTTBTrongPhong_Load(object sender, EventArgs e)
        {
            txt_TenPhong.Text = TEN_PHONG;
            string sql = "select * from TTBTrongPhong";
            grd_TTBPhong.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
        
    }
}
