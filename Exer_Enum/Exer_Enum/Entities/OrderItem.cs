using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exer_Enum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double  Price { get; set; }
        Product Product = new Product();

        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
