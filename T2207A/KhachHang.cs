using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class KhachHang
    {
        public string maKH;
        public string hoTen;
        public string ngayRaHD;
        public int soLuong;
        public double donGia;
        public virtual double TinhThanhTien()
        {
            return soLuong * donGia;
        }

        //property

        public string MaKH
        {
            get { return this.maKH; }
            set { this.maKH = value; }
        }

        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }

        public string NgayRaHD
        {
            get { return this.ngayRaHD; }
            set { this.ngayRaHD = value; }
        }

        public int SoLuong
        {
            get { return this.soLuong; }
            set { this.soLuong = value; }
        }
    }

}
