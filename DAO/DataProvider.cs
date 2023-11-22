using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CDTTTN.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string constr = "Data Source=LAPTOP-UHIR1N6O\\SQLEXPRESS;Initial Catalog=MindX_School;Integrated Security=True";
        public DataTable ExcuteQuery(string sql, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (parameter != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                conn.Close();
            }
                
            return dt;
        }

        public int ExcuteNonQuery(string sql, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (parameter != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = cmd.ExecuteNonQuery();

                conn.Close();
            }

            return dt;
        }

        public object ExcuteScalar(string sql, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (parameter != null)
                {
                    string[] listPara = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = cmd.ExecuteScalar();

                conn.Close();
            }

            return dt;
        }
    }
}
