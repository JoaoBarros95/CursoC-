using System;
using System.Collections.Generic;
using System.Globalization;
using EF_Herenca.Entities;

namespace EF_Herenca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #{0} data: ", i+1);
                Console.Write("Common, used or imported (c/u/i)?");
                string t = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(t == "i")
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(fee, name, price));
                }
                else if(t == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    list.Add(new Product(name, price));
                }                
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
            
    }
}
