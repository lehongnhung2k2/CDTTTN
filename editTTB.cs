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
    public partial class editTTB : UserControl
    {
        string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
        private frmEditTTB frmeditttb;
        string MaTTB;
        public editTTB()
        {
            InitializeComponent();

            

            //frmeditttb.Hide();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            MaTTB = txt_MaTTB_input.Text;
            if (MaTTB == "")
            {
                MessageBox.Show("Bạn chưa nhập mã trang thiết bị");
            }
            else
            {
                
                //Console.WriteLine(MaTTB);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //txt_TenTTB.Text = string.Empty;
                    connection.Open();
                    //string sql = "select * from TrangThietBi where MaTTB = '" + MaTTB + "'";
                    string sql = $"SELECT * FROM TrangThietBi WHERE MaTTB = '{MaTTB}'";
                    
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txt_MaTTB.Text = reader["MaTTB"].ToString();
                                txt_TenTTB.Text = reader["TenTTB"].ToString();
                                txt_MaTT.Text = reader["MaTT"].ToString();
                                txt_MaNCC.Text = reader["MaNCC"].ToString();
                                txt_NgayNhap.Text = reader["NgayNhap"].ToString();
                                txt_MaNV.Text = reader["MaNV"].ToString();
                                txt_NguyenGia.Text = reader["NguyenGia"].ToString();
                                txt_Thue.Text = reader["Thue"].ToString();
                                txt_ThoiGianTinhKhauHao.Text = reader["ThoiGianTinhKhauHao"].ToString();
                                txt_GhiChu.Text = reader["GhiChu"].ToString();
                            }
                            Console.WriteLine(txt_TenTTB.Text);

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy trang thiết bị với mã đã nhập.", "Thông báo");
                        }

                        // Đóng đối tượng SqlDataReader
                        reader.Close();
                    }
                }
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //string sql = $"update TrangThietBi set TenTTB = N' WHERE MaTTB = '{MaTTB}'";
                string sql = $"UPDATE TrangThietBi SET TenTTB = N'{txt_TenTTB.Text}' where MaTTB = '{MaTTB}'";

                var dataTable = new System.Data.DataTable();

                // Tạo kết nối và adapter
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        // Sử dụng SqlDataAdapter để đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo");
                }
            }
        }
    }
}
