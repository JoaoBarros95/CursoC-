using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Abstract.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExp { get; set; }

        public Individual() { }

        public Individual(double healthExp, string name, double anualIncome)
            : base (name, anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnualIncome < 20000)
            {
                tax = AnualIncome * 0.15 - HealthExp * 0.5;
            }
            else
            {
                tax = AnualIncome * 0.25 - HealthExp * 0.5;
            }
            return tax;
        }
    }
}
