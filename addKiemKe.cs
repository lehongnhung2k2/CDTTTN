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
    public partial class addKiemKe : UserControl
    {
        public addKiemKe()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm kiểm kê trang thiết bị?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                //string MaPhong = txt_MaPhong.Text;


                string constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
                string sql = $"INSERT INTO KiemKe (MaKK, NgayKK, MaNV) VALUES ('{txt_MaKK.Text}', '{txt_NgayKK.Text}', '{txt_MaNV.Text}')";
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
                addChietTietKiemKe f = new addChietTietKiemKe(txt_MaKK.Text);
                f.Show();
            }
            //string sql = $"INSERT INTO KiemKe (MaKK, NgayKK, MaNV) VALUES ('{txt_MaKK}', '{txt_NgayKK}', '{txt_MaNV}')";


            
        }
    }
}
