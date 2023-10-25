using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Rectangle
    {
        protected private readonly double radius;

        public Circle(double radius)
            : base(0,0)
        {
            this.radius = radius;
        }

        public new void Out() => Console.WriteLine($"Периметр круга: {Perimeter(radius)}\n" +
            $"Площадь круга: {Area(radius)}");

        protected double Perimeter(double radius) => 2 * Math.PI * radius;

        protected double Area(double radius) => Math.PI * radius * radius;

    }
}
