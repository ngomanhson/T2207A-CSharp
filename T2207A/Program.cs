using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using T2207A;
using System;

public class Program
{

    static List<Product> products = new List<Product>();

    public static void Main(String[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayProducts();
                    break;
                case 3:
                    DeleteProduct();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 4);

        static void AddProduct()
        {
            Console.WriteLine("Enter product details:");

            Console.Write("Product ID: ");
            string id = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Product product = new Product(id, name, price);
            products.Add(product);

            Console.WriteLine("Product added.");
        }

        static void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products to display.");
            }
            else
            {
                Console.WriteLine("Product list:");
              
                Console.WriteLine("{0,-10} {1,-20} {2,-30}", "ProductID","ProductName","Price");

                foreach (Product product in products)
                {
                    Console.WriteLine("{0,-10} {1,-20} {2,-30}", product.Id, product.Name, "$" + product.Price);
                }
                
            }
        }

        static void DeleteProduct()
        {
            Console.Write("Enter product ID to delete: ");
            string id = Console.ReadLine();

            int index = products.FindIndex(product => product.Id == id);
            if (index == -1)
            {
                Console.WriteLine("Product not found.");
            }
            else
            {
                products.RemoveAt(index);
                Console.WriteLine("Product deleted.");
            }
        }
    }
}




