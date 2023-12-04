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
    public partial class addChietTietKiemKe : Form
    {
        string MaKK;
        public addChietTietKiemKe()
        {
            InitializeComponent();
            NapCT();
            LoadTenTTB();
        }

        public addChietTietKiemKe(string maKK) : this()
        {
            MaKK = maKK;

        }
        public void NapCT()
        {
            if (grd_TTB.CurrentRow != null)
            {
                int i = grd_TTB.CurrentRow.Index;
                txt_GhiChu.Text = "";
                txt_MaTTB.Text = grd_TTB.Rows[i].Cells["MaTTB"].Value.ToString();
                txt_MaTT.Text = grd_TTB.Rows[i].Cells["MaTT"].Value.ToString();
                //Console.WriteLine(MaTTB);
            }

        }

        private void grd_TTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void LoadTenTTB()
        {
            string sql = "select distinct TenTTB from TrangThietBi";

            cb_TenTTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
            cb_TenTTB.DisplayMember = "TenTTB";
        }
        private void cb_TenTTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addChietTietKiemKe_Load(object sender, EventArgs e)
        {
            txt_MaKK.Text = MaKK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO ChiTietKiemKe (MaKK, GhiChu, MaTT, MaTTB) VALUES ('{txt_MaKK.Text}', N'{txt_GhiChu.Text}', '{txt_MaTT.Text}', '{txt_MaTTB.Text}')";
            string constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
            
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
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string TenTTB = cb_TenTTB.Text;
            //string sql = "select * from TrangThietBi";
            string sql = $"select MaTTB, TenTTB, MaTT from TrangThietBi where TenTTB = N'{TenTTB}'";
            grd_TTB.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
