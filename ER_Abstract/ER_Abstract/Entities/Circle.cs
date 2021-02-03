using System;
using System.Collections.Generic;
using System.Text;
using ER_Abstract.Entities.Enum;

namespace ER_Abstract.Entities
{
    class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
