using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using T2207A;
using System;

public class Program
{
    

    public static void Main(String[] args)
    {
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

        News news = new News();
        news.Id = 1;
        news.Title = "Hello World";
        news.PublishDate = "21-04-2023";
        news.Author = "Ngo Manh Son";
        news.Content = "This is an example news.";
        int[] rateList = { 3, 4, 5 };
        news.Calculate(rateList);
        news.Display();

        QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
        int chucNang = 0;
        do
        {
            Console.WriteLine("Chon chuc nang:");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Cap nhat thong tin sv boi ID");
            Console.WriteLine("3. Xoa sv boi ID");
            Console.WriteLine("4. Tim kiem sv theo ten");
            Console.WriteLine("5. Sap xep sv theo diem trung binh (GPA)");
            Console.WriteLine("6. Sap xep sv theo ten");
            Console.WriteLine("7. Sap xep sv theo ID");
            Console.WriteLine("8. Hien thi danh sach sv");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    quanLySinhVien.ThemSinhVien();
                    break;
                case 2:
                    quanLySinhVien.CapNhatSinhVien();
                    break;
                case 3:
                    quanLySinhVien.XoaSinhVien();
                    break;
                case 4:
                    quanLySinhVien.TimKiemSinhVien();
                    break;
                case 5:
                    quanLySinhVien.SapXepTheoDiemTrungBinh();
                    break;
                case 6:
                    quanLySinhVien.SapXepTheoTen();
                    break;
                case 7:
                    quanLySinhVien.SapXepTheoID();
                    break;
                case 8:
                    quanLySinhVien.HienThiDanhSachSinhVien();
                    break;
                case 0:
                    Console.WriteLine("Ket thuc");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong ton tai!");
                    break;
            }
            Console.WriteLine();
        } while (chucNang != 0);
    }
}




