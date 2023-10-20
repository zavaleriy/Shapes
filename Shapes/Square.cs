using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : IShape
    {
        private readonly int width; // Ширина

        public Square(int width)
        {
            this.width = width;
        }

        public void Out() => Console.WriteLine($"Периметр квадрата: {Perimeter()}\n" +
            $"Площадь квадрата: {Area()}");

        private double Perimeter() => 4 * width;

        private double Area() => width * width;


    }
}
