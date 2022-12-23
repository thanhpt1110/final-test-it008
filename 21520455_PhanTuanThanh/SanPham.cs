using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21520455_PhanTuanThanh
{
    public class SanPham
    {
        private string ma, ten;
        private double giaBan, giaNhap;
        private DateTime ngayNhap;

        public SanPham()
        {

        }

        public SanPham(string ma, string ten, double giaBan, double giaNhap, DateTime ngayNhap)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.GiaBan = giaBan;
            this.GiaNhap = giaNhap;
            this.NgayNhap = ngayNhap;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public double GiaNhap { get => giaNhap; set => giaNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }
}
