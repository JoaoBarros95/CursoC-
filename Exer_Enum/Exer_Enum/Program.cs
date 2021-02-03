using System;
using Exer_Enum.Entities.Enum;
using Exer_Enum.Entities;

namespace Exer_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string clientname = Console.ReadLine();            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientname, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #{0} item data: ", i + 1);
                Console.Write("Product name ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);
                OrderItem orderitem = new OrderItem(quantity, product);
                order.AddItem(orderitem);
            }

            Console.WriteLine(order);
            
        }
    }
}
