using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public new void Out() => Console.WriteLine($"Периметр круга: {Perimeter()}\n" +
            $"Площадь круга: {Area()}");

        private new double Perimeter() => 2 * Math.PI * radius;

        private new double Area() => Math.PI * radius * radius;

    }
}
