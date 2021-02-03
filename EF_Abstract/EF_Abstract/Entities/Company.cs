using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Abstract.Entities
{
    class Company : TaxPayer
    {
        public int Emoployees { get; set; }

        public Company() { }

        public Company(int emoployees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            Emoployees = emoployees;
        }

        public override double Tax()
        {
            double tax = 0;
            if (Emoployees < 10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }
            return tax;
        }
    }
}
