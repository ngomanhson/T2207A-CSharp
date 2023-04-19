using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using T2207A;
using System;

public class Program
{
    public static void Main(String[] args)
    {

        //    //Hoa don tien dien
        //    Console.Write("Nhap so luong khach hang Viet Nam: ");
        //    int soLuongKHVN = int.Parse(Console.ReadLine());

        //    List<KhachHangVietNam> dsKHVN = new List<KhachHangVietNam>();

        //    KhachHangVietNam khVN = new KhachHangVietNam();

        //    for (int i = 0; i < soLuongKHVN; i++)
        //    {
        //        Console.WriteLine("\nNhap thong tin khach hang Viet Nam ");
        //        Console.Write("Nhap ma khach hang: ");
        //        khVN.MaKH = Console.ReadLine();

        //        Console.Write("Nhap ho ten khach hang: ");
        //        khVN.HoTen = Console.ReadLine();

        //        Console.Write("Nhap ngay ra hoa don: ");
        //        khVN.NgayRaHD = Console.ReadLine();

        //        Console.Write("Nhap doi tuong khach hang (sinh hoat, kinh doanh, san xuat): ");
        //        khVN.DoiTuongH = Console.ReadLine();

        //        Console.Write("Nhap so luong (so KW tieu thu): ");
        //        khVN.SoLuong = int.Parse(Console.ReadLine());

        //        dsKHVN.Add(khVN);
        //    }

        //    Console.Write("\nNhap so luong khach hang nuoc ngoai: ");
        //    int soLuongKHNN = int.Parse(Console.ReadLine());

        //    List<KhachHangNuocNgoai> dsKHNN = new List<KhachHangNuocNgoai>();

        //    KhachHangNuocNgoai khNN = new KhachHangNuocNgoai();

        //    for (int i = 0; i < soLuongKHNN; i++)
        //    {
        //        Console.WriteLine("\nNhap thong tin khach hang nuoc ngoai");
        //        Console.Write("Nhap ma khach hang: ");
        //        khNN.MaKH = Console.ReadLine();

        //        Console.Write("Nhap ho ten khach hang: ");
        //        khNN.HoTen = Console.ReadLine();

        //        Console.Write("Nhap ngay ra hoa don: ");
        //        khNN.NgayRaHD = Console.ReadLine();

        //        Console.Write("Nhap quoc tich: ");
        //        khNN.QuocTich = Console.ReadLine();

        //        Console.Write("Nhap so luong: ");
        //        khNN.SoLuong = int.Parse(Console.ReadLine());

        //        dsKHNN.Add(khNN);
        //    }

        //    Console.WriteLine("\n======================================");
        //    Console.WriteLine("\nDanh sach khach hang va thanh tien:");

        //    Console.WriteLine("\nKhach hang Viet Nam:");
        //    for (int i = 0;i < soLuongKHVN; i++)
        //    {
        //        Console.WriteLine("Ma KH: " + khVN.maKH + ", ten KH: " + khVN.hoTen + ", ngay ra HD: " + khVN.ngayRaHD + ", so luong: " + khVN.soLuong + ", thanh tien: " + khVN.TinhThanhTien());
        //    }

        //    Console.WriteLine("\nKhach hang nuoc ngoai:");
        //    for (int i = 0; i < soLuongKHNN; i++)
        //    {
        //        Console.WriteLine("Ma KH: " + khNN.maKH + ", ten KH: " + khNN.hoTen + ", ngay ra HD: " + khNN.ngayRaHD + ", quoc tich: " + khNN.quocTich + ", so luong: " + khNN.soLuong + ", don gia: " + khNN.donGia + ", thanh tien: " + khNN.TinhThanhTien());
        //    }


        PhoneBook sdt = new PhoneBook();

        sdt.insertPhone("Son", "0123456");
        sdt.insertPhone("Hoang", "0654321");
        sdt.insertPhone("Vu", "0987654");

        sdt.SearchPhone("Son");
        sdt.SearchPhone("Hoang");
        sdt.SearchPhone("Duong");

        sdt.UpdatePhone("Son", "088888888");
        sdt.RemovePhone("Hoang");

        sdt.Sort();

       
    }
}
  

   

