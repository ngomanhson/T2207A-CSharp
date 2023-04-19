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
    }
}
  

   

