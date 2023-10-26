using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        protected readonly double width;
        protected readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override void Out() => Console.WriteLine($"Периметр прямоугольника: {Perimeter()}\n" +
            $"Площадь прямоугольника: {Area()}");

        protected override double Perimeter() => 2 * (width + height);

        protected override double Area() => width * height;


    }
}
