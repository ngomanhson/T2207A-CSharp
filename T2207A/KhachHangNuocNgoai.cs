using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class KhachHangNuocNgoai : KhachHang
    {
        public string quocTich;
        public double donGia = 2000;
        
        public string QuocTich
        {
            get { return this.quocTich; }
            set { this.quocTich = value;}
        }

        public override double TinhThanhTien()
        {
            return soLuong * donGia;
        }
    }
}
