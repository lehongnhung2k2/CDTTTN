using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTTTN.DTO
{
    public class DatPhongDTO
    {
        public DatPhongDTO(string maDatPhong, DateTime thoiGianDat, DateTime thoiGianMuon, DateTime thoiGianTra, string maPhong, string maNV)
        {
            this.MaDatPhong = maDatPhong;
            this.ThoiGianDat = thoiGianDat;
            this.ThoiGianMuon = thoiGianMuon;
            this.ThoiGianTra = thoiGianTra;
            this.MaPhong = maPhong;
            this.MaNV = maNV;
        }

        public DatPhongDTO (DataRow row)
        {
            this.MaDatPhong = row["MaDP"].ToString();
            this.ThoiGianDat = Convert.ToDateTime(row["ThoiGianDat"]);
            this.ThoiGianMuon = Convert.ToDateTime(row["ThoiGianMuon"]);
            this.ThoiGianTra = Convert.ToDateTime(row["ThoiGianTra"]);
            this.MaPhong = row["MaPhong"].ToString();
            this.MaNV = row["MaNV"].ToString();
        }

        private string maDatPhong;
        private DateTime thoiGianDat;
        private DateTime thoiGianMuon;
        private DateTime thoiGianTra;
        private string maPhong;
        private string maNV;

        public string MaDatPhong { get => maDatPhong; set => maDatPhong = value; }
        public DateTime ThoiGianDat { get => thoiGianDat; set => thoiGianDat = value; }
        public DateTime ThoiGianMuon { get => thoiGianMuon; set => thoiGianMuon = value; }
        public DateTime ThoiGianTra { get => thoiGianTra; set => thoiGianTra = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
