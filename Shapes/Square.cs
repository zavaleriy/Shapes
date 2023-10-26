using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        protected readonly double width; // Ширина

        public Square(double width)
        {
            this.width = width;
        }

        public override void Out() => Console.WriteLine($"Периметр квадрата: {Perimeter()}\n" +
            $"Площадь квадрата: {Area()}");

        protected override double Perimeter() => 4 * width;

        protected override double Area() => width * width;


    }
}
