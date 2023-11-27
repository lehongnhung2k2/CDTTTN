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
    public partial class addTTB : UserControl
    {
        public addTTB()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm mới trang thiết bị này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                //string MaPhong = txt_MaPhong.Text;

                
                string constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
                string sql = "INSERT INTO TrangThietBi (MaTTB, TenTTB, NgayNhap, ThoiGianTinhKhauHao, Thue, NguyenGia, MaTT, MaNCC, MaNV, TrangThaiTrongPhong) VALUES ('"
                    + txt_MaTTB.Text + "', N'" + txt_TenTTB.Text + "', '" + txt_NgayNhap.Text + "', " + txt_ThoiGianTinhKhauHao.Text + ", " + txt_Thue.Text + ", " + txt_NguyenGia.Text + ", '" + cb_MaTT.Text + "', '" + txt_MaNCC.Text + "', '" + txt_MaNV.Text + "', 0)";
                Console.WriteLine(sql);
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
                MessageBox.Show("Thêm trang thiết bị thành công");
            }
        }

        private void addTTB_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            string sql = "select distinct MaTT from TrangThai";

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
            cb_MaTT.DataSource = dataTable;
            cb_MaTT.DisplayMember = "MaTT";
        }
    }
}
