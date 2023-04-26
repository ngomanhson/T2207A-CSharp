using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class SinhVien
    {
        public int id;
        public string ten;
        public string gioiTinh;
        public int tuoi;
        public double diemToan;
        public double diemLy;
        public double diemHoa;
        public double diemTrungBinh;
        public string hocLuc;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public int Tuoi
        {
            get => tuoi;
            set => tuoi = value;
        }

        public double DiemToan
        {
            get => diemToan;
            set => diemToan = value;
        }

        public double DiemLy
        {
            get => diemLy;
            set => diemLy = value;
        }

        public double DiemHoa
        {
            get => diemHoa;
            set => diemHoa = value;
        }

        public double DiemTrungBinh
        {
            get => diemTrungBinh;
            set => diemTrungBinh = value;
        }

        public string HocLuc
        {
            get => hocLuc;
            set => hocLuc = value;
        }



        public void TinhDiemTrungBinh()
        {
            diemTrungBinh = (diemToan + diemLy + diemHoa) / 3;
        }

        public void TinhHocLuc()
        {
            if (diemTrungBinh >= 8)
            {
                hocLuc = "Gioi";
            }
            else if (diemTrungBinh >= 6.5)
            {
                hocLuc = "Kha";
            }
            else if (diemTrungBinh >= 5)
            {
                hocLuc = "Trung Binh";
            }
            else
            {
                hocLuc = "Yeu";
            }
        }

        public override string ToString()
        {
            return id + "\t" + ten + "\t" + gioiTinh + "\t" + tuoi + "\t" + diemToan + "\t" + diemLy + "\t" + diemHoa + "\t" + diemTrungBinh + "\t" + hocLuc;
        }
    }
}

