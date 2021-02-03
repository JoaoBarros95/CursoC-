using System;
using System.Collections.Generic;
using System.Text;
using Exer_Enum.Entities.Enum;
using System.Globalization;

namespace Exer_Enum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Clients { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client clients)
        {
            Moment = moment;
            Status = status;
            Clients = clients;
        }

        public void AddItem(OrderItem Item)
        {
            OrderItems.Add(Item);
        }

        public void RemoveItem(OrderItem Item)
        {
            OrderItems.Remove(Item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem order in OrderItems)
            {
                sum += order.SubTotal(); 
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Clients);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
