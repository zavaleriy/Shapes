using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Square
    {
        private readonly int height; // Высота

        public Rectangle(int width, int height) 
            : base(width)
        {
            this.height = height;
        }

        public new void Out() => Console.WriteLine($"Периметр прямоугольника: {Perimeter(width, height)}\n" +
            $"Площадь прямоугольника: {Area(width, height)}");

        private double Perimeter(int width, int height) => 2 * (width + height);

        private double Area(int width, int height) => width * height;


    }
}
