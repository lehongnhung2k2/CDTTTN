using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDTTTN.DTO;
using System.Data;
using CDTTTN.DAO;

namespace CDTTTN.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }
        public static int PhongDai = 200;

        public static int PhongRong = 200;
        private PhongDAO() { }
        public List<Phong> LoadPhongList()
        {
            List<Phong> phongList = new List<Phong>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_GetPhongList");
            
            foreach (DataRow item in dt.Rows)
            {
                Phong phong = new Phong(item);
                phongList.Add(phong);

            }

            return phongList;
        }
    }
}
