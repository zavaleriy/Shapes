using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shapes
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Perimeter() => 2 * Math.PI * radius;

        public double Area() => Math.PI * radius * radius;

    }
}
