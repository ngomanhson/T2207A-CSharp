using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using T2207A;
using System;

public class Program
{
    public static void Main(String[] args)
    {
        //Phan so
        //Fraction ps1 = new Fraction();
        //ps1.NhapPhanSo();
        //Console.Write("phan so thu nhat la: ");
        //ps1.InPhanSo();

        //Fraction ps2 = new Fraction();
        //ps2.NhapPhanSo();
        //Console.Write("phan so thu hai la: ");
        //ps2.InPhanSo();

        //Console.WriteLine("==========================");

        //Console.Write("Tong hai phan so la: ");
        //Fraction ps3 = Fraction.Add(ps1, ps2);
        //ps3.InPhanSo();

        //Console.Write("Hieu hai phan so la: ");
        //Fraction ps4 = Fraction.Sub(ps1, ps2);
        //ps4.InPhanSo();

        //Console.Write("Tich hai phan so la: ");
        //Fraction ps5 = Fraction.Mul(ps1, ps2);
        //ps5.InPhanSo();

        //Console.Write("Thuong hai phan so la: ");
        //Fraction ps6 = Fraction.Div(ps1, ps2);
        //ps6.InPhanSo();


        //Hoa don tien dien
        Console.Write("Nhap so luong khach hang Viet Nam: ");
        int soLuongKHVN = int.Parse(Console.ReadLine());

        List<KhachHangVietNam> dsKHVN = new List<KhachHangVietNam>();

        KhachHangVietNam khVN = new KhachHangVietNam();

        for (int i = 0; i < soLuongKHVN; i++)
        {
            Console.WriteLine("\nNhap thong tin khach hang Viet Nam ");
            Console.Write("Nhap ma khach hang: ");
            khVN.MaKH = Console.ReadLine();

            Console.Write("Nhap ho ten khach hang: ");
            khVN.HoTen = Console.ReadLine();

            Console.Write("Nhap ngay ra hoa don: ");
            khVN.NgayRaHD = Console.ReadLine();

            Console.Write("Nhap doi tuong khach hang (sinh hoat, kinh doanh, san xuat): ");
            khVN.DoiTuongH = Console.ReadLine();

            Console.Write("Nhap so luong (so KW tieu thu): ");
            khVN.SoLuong = int.Parse(Console.ReadLine());

            dsKHVN.Add(khVN);
        }

        Console.Write("\nNhap so luong khach hang nuoc ngoai: ");
        int soLuongKHNN = int.Parse(Console.ReadLine());

        List<KhachHangNuocNgoai> dsKHNN = new List<KhachHangNuocNgoai>();

        KhachHangNuocNgoai khNN = new KhachHangNuocNgoai();

        for (int i = 0; i < soLuongKHNN; i++)
        {
            Console.WriteLine("\nNhap thong tin khach hang nuoc ngoai");
            Console.Write("Nhap ma khach hang: ");
            khNN.MaKH = Console.ReadLine();

            Console.Write("Nhap ho ten khach hang: ");
            khNN.HoTen = Console.ReadLine();

            Console.Write("Nhap ngay ra hoa don: ");
            khNN.NgayRaHD = Console.ReadLine();

            Console.Write("Nhap quoc tich: ");
            khNN.QuocTich = Console.ReadLine();

            Console.Write("Nhap so luong: ");
            khNN.SoLuong = int.Parse(Console.ReadLine());

            dsKHNN.Add(khNN);
        }

        Console.WriteLine("\n======================================");
        Console.WriteLine("\nDanh sach khach hang va thanh tien:");

        Console.WriteLine("\nKhach hang Viet Nam:");
        for (int i = 0;i < soLuongKHVN; i++)
        {
            Console.WriteLine("Ma KH: " + khVN.maKH + ", ten KH: " + khVN.hoTen + ", ngay ra HD: " + khVN.ngayRaHD + ", so luong: " + khVN.soLuong + ", thanh tien: " + khVN.TinhThanhTien());
        }

        Console.WriteLine("\nKhach hang nuoc ngoai:");
        for (int i = 0; i < soLuongKHNN; i++)
        {
            Console.WriteLine("Ma KH: " + khNN.maKH + ", ten KH: " + khNN.hoTen + ", ngay ra HD: " + khNN.ngayRaHD + ", quoc tich: " + khNN.quocTich + ", so luong: " + khNN.soLuong + ", don gia: " + khNN.donGia + ", thanh tien: " + khNN.TinhThanhTien());
        }
    }
}
  

   

