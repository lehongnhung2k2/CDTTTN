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
        
        string MaTTB, MaTT, TrangThai;
        public DieuChuyenTTB()
        {
            InitializeComponent();
        }

        private void DieuChuyenTTB_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi trạng thái trang thiết bị này không?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Có" hay không
            if (result == DialogResult.Yes)
            {
                string sql = $"update TrangThietBi set MaTT = '{TrangThai}' where MaTTB = '{MaTTB}'";
                grd.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            }
            
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
            flp_TrangThai.Controls.Clear();
            RadioButton btn_SuDung = new RadioButton();
            btn_SuDung.Text = "Sử dụng";
            btn_SuDung.Font = new Font("Microsoft Sans Serif", 10);

            RadioButton btn_SuaChua = new RadioButton();
            btn_SuaChua.Text = "Sửa chữa";
            btn_SuaChua.Font = new Font("Microsoft Sans Serif", 10);

            RadioButton btn_ThanhLy = new RadioButton();
            btn_ThanhLy.Text = "Thanh lý";
            btn_ThanhLy.Font = new Font("Microsoft Sans Serif", 10);

            if (MaTT == "TT001")
            {
                txt_TenTT.Text = "Sử dụng";
                flp_TrangThai.Controls.Add(btn_SuaChua);
                flp_TrangThai.Controls.Add(btn_ThanhLy);
            }
            else if (MaTT == "TT002")
            {
                txt_TenTT.Text = "Sửa chữa";
                flp_TrangThai.Controls.Add(btn_SuDung);
                flp_TrangThai.Controls.Add(btn_ThanhLy);
            }
            else
            {
                txt_TenTT.Text = "Thanh lý";
                flp_TrangThai.Controls.Add(btn_SuDung);
                flp_TrangThai.Controls.Add(btn_SuaChua);
            }
            btn_SuDung.Click += Btn_SuDung_Click;
            btn_SuaChua.Click += Btn_SuaChua_Click;
            btn_ThanhLy.Click += btn_ThanhLy_Click;
            //myRadioButton.Click += MyRadioButton_Click;
        }

        private void btn_ThanhLy_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về RadioButton để truy cập thuộc tính Checked
            RadioButton clickedRadioButton = (RadioButton)sender;

            // Kiểm tra nếu radio button được chọn
            if (clickedRadioButton.Checked)
            {
                TrangThai = "TT003";
            }
        }

        private void Btn_SuaChua_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về RadioButton để truy cập thuộc tính Checked
            RadioButton clickedRadioButton = (RadioButton)sender;

            // Kiểm tra nếu radio button được chọn
            if (clickedRadioButton.Checked)
            {
                TrangThai = "TT002";
            }
        }

        private void Btn_SuDung_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về RadioButton để truy cập thuộc tính Checked
            RadioButton clickedRadioButton = (RadioButton)sender;

            // Kiểm tra nếu radio button được chọn
            if (clickedRadioButton.Checked)
            {
                TrangThai = "TT001";
            }
        }
    }
}
