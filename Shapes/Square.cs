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

        public override void Out() => Console.WriteLine($"Периметр квадрата: {Perimeter(width)}\n" +
            $"Площадь квадрата: {Area(width)}");

        protected double Perimeter(double width) => 4 * width;

        protected double Area(double width) => width * width;


    }
}
