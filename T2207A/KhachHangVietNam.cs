using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class KhachHangVietNam : KhachHang
    {
        public string doiTuongKH;

        public string DoiTuongH
        {
            get { return this.doiTuongKH; }
            set { this.doiTuongKH = value; }
        }

        public override double TinhThanhTien()
        {
            double thanhTien = 0;
            double dinhMuc = 0;
            double donGiaDinhMucThu1 = 0;
            double donGiaDinhMucThu2 = 0;
            double soLuongVuotDinhMuc = 0;

            switch (doiTuongKH)
            {
                case "sinh hoat":
                    dinhMuc = 50;
                    donGiaDinhMucThu1 = 1000;
                    donGiaDinhMucThu2 = 1200;
                    break;
                case "kinh doanh":
                    dinhMuc = 100;
                    donGiaDinhMucThu1 = 1200;
                    donGiaDinhMucThu2 = 1500;
                    break;
                case "san xuat":
                    dinhMuc = 200;
                    donGiaDinhMucThu1 = 1500;
                    donGiaDinhMucThu2 = 2000;
                    break;
            }

            if (soLuong <= dinhMuc)
            {
                thanhTien = soLuong * donGiaDinhMucThu1;
            }
            else
            {
                soLuongVuotDinhMuc = soLuong - dinhMuc;
                thanhTien = dinhMuc * donGiaDinhMucThu1 + soLuongVuotDinhMuc * donGiaDinhMucThu2;
            }
            return thanhTien;
        }
    }
}
