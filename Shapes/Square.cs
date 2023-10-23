using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square
    {
        protected private readonly int width; // Ширина

        public Square(int width)
        {
            this.width = width;
        }

        public void Out() => Console.WriteLine($"Периметр квадрата: {Perimeter(width)}\n" +
            $"Площадь квадрата: {Area(width)}");

        private double Perimeter(int width) => 4 * width;

        private double Area(int width) => width * width;


    }
}
