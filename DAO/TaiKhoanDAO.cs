using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDTTTN.DAO;
using System.Data;

namespace CDTTTN.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance 
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }

        public bool checkDangNhap(string tk, string mk)
        {
            string sql = "select count(*) from TaiKhoan "
                + " where " + "TenTK" + "=N'" + tk + "'"
                + " and " + " Matkhau" + "=N'" + mk + "'"
                + " and " + " MaPQ =N'admin'";
            DataTable result = DataProvider.Instance.ExcuteQuery(sql);
            return result.Rows.Count > 0;
        }
    }
}
