using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EF_Herenca.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct() { }

        public UsedProduct(DateTime date, string name, double price)
            : base (name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + Date.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
