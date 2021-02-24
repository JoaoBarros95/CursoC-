using System;
using System.Collections.Generic;
using System.Linq;

namespace ER_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(q => q.Price >= 100);
            //list.ForEach(q => q.Price += q.Price * 0.100);
            list.Select(q => q.Name.ToUpper());
            List<string> w = list.Select(q => q.Name.ToUpper()).ToList();

            foreach(string q in w)
            {
                Console.WriteLine(q);
            }
        }
    }
}
