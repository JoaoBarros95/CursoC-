using System;
using System.Collections.Generic;
using System.Text;

namespace ER_herança.NewFolder
{
    class OutsourcedEmployee : Emlpoyee
    {
        public double Charge { get; set; }

        public OutsourcedEmployee(string name, int hours, double value, double charge)
            : base (name, hours, value)
        {
            Charge = charge;
        }

        public override double Payment()
        {
            return base.Payment() + Charge * 1.1;
        }
    }
}
