using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        protected readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void Out() => Console.WriteLine($"Периметр круга: {Perimeter()}\n" +
            $"Площадь круга: {Area()}");

        protected override double Perimeter() => 2 * Math.PI * radius;

        protected override double Area() => Math.PI * radius * radius;

    }
}
