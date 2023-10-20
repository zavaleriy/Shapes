using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : IShape
    {
        private readonly int width; // Ширина
        private readonly int height; // Высота

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Out() => Console.WriteLine($"Периметр прямоугольника: {Perimeter()}\n" +
            $"Площадь прямоугольника: {Area()}");

        private double Perimeter() => 2 * (width + height);

        private double Area() => height * width;


    }
}
