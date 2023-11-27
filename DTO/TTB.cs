using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDTTTN.DTO
{
    public class TTB
    {
        //public TTB(string maTTB, string tenTTB, string maTT, string maNCC, string ngayNhap, string maNV, int nguyenGia, float thue, int thoiGianTinhKhauHao, string ghiChu)
        //{
        //    this.MaTTB = maTTB;
        //    this.TenTTB = tenTTB;
        //    this.MaTT = maTT;
        //    this.MaNCC = maNCC;
        //    this.NgayNhap = ngayNhap;
        //    this.MaNV = maNV;
        //    this.NguyenGia = nguyenGia;
        //    this.Thue = thue;
        //    this.ThoiGianTinhKhauHao = thoiGianTinhKhauHao;
        //    this.GhiChu = ghiChu;
        //}
        //public TTB(DataRow row)
        //{
        //    this.MaTTB = row["MaTTB"].ToString();
        //    this.TenTTB = row["TenTTB"].ToString();
        //    this.MaTT = row["MaTT"].ToString();
        //    this.MaNCC = row["MaNCC"].ToString();
        //    this.NgayNhap = row["NgayNhap"].ToString();
        //    this.MaNV = row["MaNV"].ToString();
        //    this.NguyenGia = (int)(row["NguyenGia"]);
        //    this.Thue = (float)(row["Thue"]);
        //    this.ThoiGianTinhKhauHao = (int)(row["ThoiGianTinhKhauHao"]);
        //    this.GhiChu = row["GhiChu"].ToString();
        //}

        private string maTTB;
        public string MaTTB
        {
            get { return maTTB; }
            set { maTTB = value; }
        }

        private string tenTTB;
        public string TenTTB
        {
            get { return tenTTB; }
            set { tenTTB = value; }
        }

        public string MaTT { get => maTT; set => maTT = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int NguyenGia { get => nguyenGia; set => nguyenGia = value; }
        public float Thue { get => thue; set => thue = value; }
        public int ThoiGianTinhKhauHao { get => thoiGianTinhKhauHao; set => thoiGianTinhKhauHao = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        private string maTT;

        private string maNCC;

        private string ngayNhap;

        private string maNV;

        private int nguyenGia;

        private float thue;

        private int thoiGianTinhKhauHao;

        private string ghiChu;

    }
}
