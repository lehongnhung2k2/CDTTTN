using CDTTTN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTTTN.DAO
{
    public class DatPhongDAO
    {
        private static DatPhongDAO instance;
        public static DatPhongDAO Instance
        {
            get { if (instance == null) instance = new DatPhongDAO(); return DatPhongDAO.instance; }
            private set { DatPhongDAO.instance = value; }
        }
        private DatPhongDAO() { }
        public List<DatPhongDTO> LoadDatPhongList()
        {
            List<DatPhongDTO> datphongList = new List<DatPhongDTO>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("USP_GetDatPhongList");

            foreach (DataRow item in dt.Rows)
            {
                DatPhongDTO datphong = new DatPhongDTO(item);
                datphongList.Add(datphong);

            }

            return datphongList;
        }
    }
}
