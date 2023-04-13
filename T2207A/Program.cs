using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using T2207A;

public class Program
{
    public static void Main(String[] args)
    {
        //Phan so
        Fraction ps1 = new Fraction();
        ps1.NhapPhanSo();
        Console.Write("Phan so thu nhat la: ");
        ps1.InPhanSo();

        Fraction ps2 = new Fraction();
        ps2.NhapPhanSo();
        Console.Write("Phan so thu hai la: ");
        ps2.InPhanSo();

        Console.WriteLine("==========================");

        Console.Write("Tong hai phan so la: ");
        Fraction ps3 = Fraction.Add(ps1, ps2);
        ps3.InPhanSo();

        Console.Write("Hieu hai phan so la: ");
        Fraction ps4 = Fraction.Sub(ps1, ps2);
        ps4.InPhanSo();

        Console.Write("Tich hai phan so la: ");
        Fraction ps5 = Fraction.Mul(ps1, ps2);
        ps5.InPhanSo();

        Console.Write("Thuong hai phan so la: ");
        Fraction ps6 = Fraction.Div(ps1, ps2);
        ps6.InPhanSo();
    }
}

