using System;
using System.Collections.Generic;
using System.Text;

namespace ER_herança.NewFolder
{
    class Emlpoyee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double Value { get; set; }

        public Emlpoyee() { }

        public Emlpoyee(string name, int hours, double value)
        {
            Name = name;
            Hours = hours;
            Value = value;
        }

        public virtual double Payment()
        {
            return Hours * Value;
        }
    }
}
