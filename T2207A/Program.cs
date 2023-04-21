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
    }
}




