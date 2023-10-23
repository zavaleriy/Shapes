using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        protected private readonly int width; // Ширина

        public Square(int width)
        {
            this.width = width;
        }

        public new void Out() => Console.WriteLine($"Периметр квадрата: {Perimeter()}\n" +
            $"Площадь квадрата: {Area()}");

        private new double Perimeter() => 4 * width;

        private new double Area() => width * width;


    }
}
