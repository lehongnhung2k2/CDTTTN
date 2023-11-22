using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTTTN.DTO
{
    public class Phong
    {
        public Phong(string maPhong, string tenPhong, int soLuong, string trangThai)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.SoLuong = soLuong;
            this.TrangThai = trangThai;
        }
        public Phong(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.TenPhong = row["TenPhong"].ToString();
            this.SoLuong = (int)(row["SoLuong"]);
            this.TrangThai = row["TrangThaiPhong"].ToString();
        }
        private string maPhong;
        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        private string tenPhong;
        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
