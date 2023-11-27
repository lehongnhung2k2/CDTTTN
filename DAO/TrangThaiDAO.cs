using CDTTTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTTTN.DAO
{
    public class TrangThaiDAO
    {
        private static TrangThaiDAO instance;
        public static TrangThaiDAO Instance
        {
            get { if (instance == null) instance = new TrangThaiDAO(); return TrangThaiDAO.instance; }
            private set { TrangThaiDAO.instance = value; }
        }
        public static int size = 10;

        private TrangThaiDAO() { }
        public List<TrangThai> LoadTrangThaiList()
        {
            List<TrangThai> trangthaiList = new List<TrangThai>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_GetTrangThaiList");

            foreach (DataRow item in dt.Rows)
            {
                TrangThai trangthai = new TrangThai(item);
                trangthaiList.Add(trangthai);

            }

            return trangthaiList;
        }
    }
}
