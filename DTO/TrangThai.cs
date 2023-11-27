using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTTTN.DTO
{
    public class TrangThai
    {
        public TrangThai(string maTT, string tenTT)
        {
            this.MaTT = maTT;
            this.TenTT = tenTT;
        }
        public TrangThai(DataRow row)
        {
            this.MaTT = row["MaTT"].ToString();
            this.TenTT = row["TenTT"].ToString();
        }
        private string maTT;
        private string tenTT;

        public string MaTT { get => maTT; set => maTT = value; }
        public string TenTT { get => tenTT; set => tenTT = value; }
    }
}
