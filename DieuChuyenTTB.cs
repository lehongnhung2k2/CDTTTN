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
    public partial class DieuChuyenTTB : UserControl
    {
        
        string connectionString = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
        
        string MaTTB, MaTT;
        public DieuChuyenTTB()
        {
            InitializeComponent();
        }

        private void DieuChuyenTTB_Load(object sender, EventArgs e)
        {
            
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
                                
                                MaTT = reader["MaTT"].ToString();
                                
                            }

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
            if (MaTT == "TT001")
            {
                txt_TenTT.Text = "Đang sử dụng";
            }
            else if (MaTT == "TT002")
            {
                txt_TenTT.Text = "Sửa chữa";
            }
            else
            {
                txt_TenTT.Text = "Thanh lý";
            }
            flp_TrangThai.Controls.Clear();
            List<TrangThai> trangthaiList = TrangThaiDAO.Instance.LoadTrangThaiList();
            foreach (TrangThai item in trangthaiList)
            {
                RadioButton btn = new RadioButton();
                btn.Font = new Font("Microsoft Sans Serif", 10);
                if (item.MaTT != MaTT && item.MaTT !="")
                {
                    btn.Text = item.TenTT;
                    flp_TrangThai.Controls.Add(btn);
                }

                
            }
        }
    }
}
