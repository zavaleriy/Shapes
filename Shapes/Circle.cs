using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Out() => Console.WriteLine($"Периметр круга: {Perimeter()}\n" +
            $"Площадь круга: {Area()}");

        private double Perimeter() => 2 * Math.PI * radius;

        private double Area() => Math.PI * radius * radius;

    }
}
